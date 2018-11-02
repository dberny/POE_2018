///*
//  spindle_control.c - spindle control methods
//  Part of Grbl
//
//   The MIT License (MIT)
//
//  GRBL(tm) - Embedded CNC g-code interpreter and motion-controller
//  Copyright (c) 2009-2011 Simen Svale Skogsrud
//  Copyright (c) 2011-2013 Sungeun K. Jeon
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//*/
//
#include "settings.h"
#include "spindle_control.h"
#include "protocol.h"
#include "gcode.h"
#include "planner.h"
#include "fastio.h"
#include "Arduino.h"
#include "print.h"
#include <avr/pgmspace.h>
#include "report.h"
#include "print.h"
#include "settings.h"
#include "nuts_bolts.h"
#include "gcode.h"

static uint8_t current_direction;
uint16_t current_rpm;

void spindle_init()
{
  current_direction = 0;
  SPINDLE_PWM_DDR |= (1 << SPINDLE_PWM_BIT); // Configure as PWM output pin. must have!
  spindle_stop();
}

void spindle_stop()
{
  TCCRA_REGISTER &= ~(1 << COMB_BIT); // Disable PWM. Output voltage is zero.
}

void spindle_run(int8_t direction, uint16_t rpm)
{
    
  if (direction != current_direction || rpm != current_rpm) {
    plan_synchronize();
    if (direction==0) { //If M5, then stop, else, read input and adjust accordingly
        
        spindle_stop();
      
    } else {
        //Spindle Timer Chooches here!
        #define SPINDLE_RPM_RANGE (SPINDLE_MAX_RPM-SPINDLE_MIN_RPM)
        TCCRA_REGISTER = (1 << COMB_BIT) | (1 << WAVE1_REGISTER);// | (1 << WAVE0_REGISTER); //WAVE0 Register is not setup in Mode 14 Timer, but should be used when switching back to digital Pin 9
        TCCRB_REGISTER = (TCCRB_REGISTER & 0b11111000) | (1<<CS41) | (1<<WAVE2_REGISTER)| (1<<WAVE3_REGISTER); // set to 1/8 Prescaler
        OCR_REGISTER_TOP = 0xFF; //0xFF for 16bit Timer to count to 255, instead of 65535. This value should be 0XFFFF for a normal 16bit Timer
                                    
        rpm -= SPINDLE_MIN_RPM;
        if (rpm > SPINDLE_RPM_RANGE) {
            rpm = SPINDLE_RPM_RANGE;
        } // Prevent uint16 overflow
        
        current_rpm=rpm;
        uint16_t current_pwm;               
        current_pwm = floor(rpm * (PWM_MAX_VALUE / SPINDLE_RPM_RANGE)); 
        OCR_REGISTER = current_pwm;
    }
    current_direction = direction;
  }
}


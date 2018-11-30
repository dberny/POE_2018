/*
  pin_map.h - Pin mapping configuration file
  Part of Grbl

  Copyright (c) 2013 Sungeun K. Jeon

   The MIT License (MIT)

  GRBL(tm) - Embedded CNC g-code interpreter and motion-controller
  Copyright (c) 2009-2011 Simen Svale Skogsrud
  Copyright (c) 2011-2013 Sungeun K. Jeon

  Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in
  all copies or substantial portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
  THE SOFTWARE.
*/

/* The pin_map.h file serves as a central pin mapping settings file for different processor
   types, i.e. AVR 328p or AVR Mega 2560. Grbl officially supports the Arduino Uno, but the
   other supplied pin mappings are supplied by users, so your results may vary. */

#ifndef pin_map_h
#define pin_map_h
#include "config.h"    // PIN_MAP_ARDUINO_MEGA_2560


//************************************************************************************************
//Adaptado para RAMPS 1.4:
#ifdef PIN_MAP_CUSTOM_PROC
  // For a custom pin map or different processor, copy and paste one of the default pin map
  // settings above and modify it to your needs. Then, make sure the defined name is also
  // changed in the config.h file.

#ifndef AXIS_T_TYPE
    #error "The macro "AXIS_T_TYPE" is not defined in 'config.h' !"
#endif

#ifndef AXIS_R_TYPE
    #error "The macro "AXIS_R_TYPE" is not defined in 'config.h' !"
#endif

  // Serial port pins
  #define SERIAL_RX USART0_RX_vect
  #define SERIAL_UDRE USART0_UDRE_vect

  // NOTE: All step bit and direction pins must be on the same port.
  #define STEPPING_DDR      DDRA
  #define STEPPING_PORT     PORTA
  #define STEPPING_PIN      PINA
  #define X_STEP_BIT        2 // MEGA2560 Digital Pin 24
  #define Y_STEP_BIT        3 // MEGA2560 Digital Pin 25
  #define Z_STEP_BIT        4 // MEGA2560 Digital Pin 26
/// 8c2
  #define T_STEP_BIT        1 // MEGA2560 Digital Pin 23
  #define R_STEP_BIT        5

  #define X_DIRECTION_BIT   5 // MEGA2560 Digital Pin 27
  #define Y_DIRECTION_BIT   6 // MEGA2560 Digital Pin 28
  #define Z_DIRECTION_BIT   7 // MEGA2560 Digital Pin 29
/// 8c2
  #define T_DIRECTION_BIT   0 // MEGA2560 Digital Pin 22
  #define R_DIRECTION_BIT   4
  // All step bits
  #define STEP_MASK ((1<<X_STEP_BIT)|(1<<Y_STEP_BIT)|(1<<Z_STEP_BIT)|(1<<T_STEP_BIT)|(1<<R_STEP_BIT))
  // All direction bits
  #define DIRECTION_MASK ((1<<X_DIRECTION_BIT)|(1<<Y_DIRECTION_BIT)|(1<<Z_DIRECTION_BIT) |(1<<T_DIRECTION_BIT)|(1<<R_DIRECTION_BIT))

/// <--
  // All stepping-related bits (step/direction)
  #define STEPPING_MASK (STEP_MASK | DIRECTION_MASK)

/// 8c2
   // Define stepper driver enable/disable output pin.
    #define STEPPERS_DISABLE_DDR    DDRB
    #define STEPPERS_DISABLE_PORT   PORTB
    #define STEPPERS_DISABLE_BIT    7  // MEGA2560 Digital Pin 13
    // STEPPERS_DISABLE_INVERT: Set to 0 for active high stepper disable or 1
    // for active low stepper disable.
    #define STEPPERS_DISABLE_INVERT 0
    #define STEPPERS_DISABLE_MASK (1<<STEPPERS_DISABLE_BIT)
/// <---
  // NOTE: All limit bit pins must be on the same port
  #define LIMIT_DDR       DDRB
  #define LIMIT_PORT      PORTB
  #define LIMIT_PIN       PINB
  #define X_LIMIT_BIT     4 // MEGA2560 Digital Pin 10
  #define Y_LIMIT_BIT     5 // MEGA2560 Digital Pin 11
  #define Z_LIMIT_BIT     6 // MEGA2560 Digital Pin 12
/// 8c2
  #define T_LIMIT_BIT   3 // MEGA2560 Digital Pin 9
  #define R_LIMIT_BIT   2

  #define LIMIT_INT       PCIE0  // Pin change interrupt enable pin
  #define LIMIT_INT_vect  PCINT0_vect
  #define LIMIT_PCMSK     PCMSK0 // Pin change interrupt register
  #define LIMIT_MASK ((1<<X_LIMIT_BIT)|(1<<Y_LIMIT_BIT)|(1<<Z_LIMIT_BIT) |(1<<T_LIMIT_BIT)|(1<<R_LIMIT_BIT)) // All limit bits

  #define SPINDLE_ENABLE_DDR   DDRC
  #define SPINDLE_ENABLE_PORT  PORTC
  #define SPINDLE_ENABLE_BIT   2 // MEGA2560 Digital Pin 35

  #define SPINDLE_DIRECTION_DDR   DDRC
  #define SPINDLE_DIRECTION_PORT  PORTC
  #define SPINDLE_DIRECTION_BIT   1 // MEGA2560 Digital Pin 36

  #define COOLANT_FLOOD_DDR   DDRC
  #define COOLANT_FLOOD_PORT  PORTC
  #define COOLANT_FLOOD_BIT   0 // MEGA2560 Digital Pin 37

  // #define ENABLE_M7  // Mist coolant disabled by default. Uncomment to enable.
  #ifdef ENABLE_M7
    #define COOLANT_MIST_DDR   DDRC
    #define COOLANT_MIST_PORT  PORTC
    #define COOLANT_MIST_BIT   3 // MEGA2560 Digital Pin 34
  #endif

  // NOTE: All pinouts pins must be on the same port
  #define PINOUT_DDR       DDRK
  #define PINOUT_PIN       PINK
  #define PINOUT_PORT      PORTK
  #define PIN_RESET        0  // MEGA2560 Analog Pin 8
  #define PIN_FEED_HOLD    1  // MEGA2560 Analog Pin 9
  #define PIN_CYCLE_START  2  // MEGA2560 Analog Pin 10
  #define PROBE        3  // MEGA2560 Analog Pin 11
  #define PINOUT_INT       PCIE2  // Pin change interrupt enable pin
  #define PINOUT_INT_vect  PCINT2_vect
  #define PINOUT_PCMSK     PCMSK2 // Pin change interrupt register
  #define PINOUT_MASK ((1<<PIN_RESET)|(1<<PIN_FEED_HOLD)|(1<<PIN_CYCLE_START))

////////Set Timer up to use TIMER4C which is attached to Digital Pin 8
#define PWM_MAX_VALUE 255
#define TCCRA_REGISTER    TCCR4A
#define TCCRB_REGISTER    TCCR4B
#define OCR_REGISTER      OCR4C
#define OCR_REGISTER_TOP  ICR4

#define COMB_BIT          COM4C1
#define WAVE0_REGISTER    WGM40
#define WAVE1_REGISTER    WGM41
#define WAVE2_REGISTER    WGM42
#define WAVE3_REGISTER    WGM43

#define SPINDLE_PWM_DDR   DDRH
#define SPINDLE_PWM_PORT  PORTH
#define SPINDLE_PWM_BIT   5 // MEGA2560 Digital Pin 8 ; Controla a saida D8 de 0V até a voltagem de alimentação na entrada 11A


// MOD GRBL for Cyclone
// actually maps to arduino mega2560
#define XLIM_PIN            3
#define YLIM_PIN           14

//e0 motor
#define X_STEP_PIN         26 //54 //PF0 ( ADC0 )
#define X_DIR_PIN          28 //55 //PF1 ( ADC1 )
#define X_ENABLE_PIN       24 //38 //PD7 ( T0 )

//e1 motor
#define Y_STEP_PIN         36 //60 //PF6 ( ADC6 )
#define Y_DIR_PIN          34 //61 //PF7 ( ADC7 )
#define Y_ENABLE_PIN       30 //56 //PF2 ( ADC2 )

//z motor
#define Z_STEP_PIN         46 //46 //PL3 ( OC5A )
#define Z_DIR_PIN          48 //48 //PL1 ( ICP5 )
#define Z_ENABLE_PIN       62 //62 //PK0 ( ADC8/PCINT16 )

//y motor
#define E0_STEP_PIN        60 //26 //PA4 4TH AXIS IS CONFIGURED HERE! CAN BE CHANGED IN RAMPS.H
#define E0_DIR_PIN         61 //28 //PA6
#define E0_ENABLE_PIN      56 //24 //PA2

//x motor
#define E1_STEP_PIN         54 //36 
#define E1_DIR_PIN          55 //34
#define E1_ENABLE_PIN       58 //30


#endif
//***************************************************************************************************







#endif

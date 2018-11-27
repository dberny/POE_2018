
#read file
with open('triangleGcode.txt', 'r+') as file:
    lines = file.readlines()
    for line in lines:
        print(type(line))

        words = line.split()
        newline = ''
        for word in words:
            if (word[0] == 'X'):
                newline = newline + ' ' + word + ' U-' + word[1:]
            elif (word[0] == 'Y'):
                newline = newline + ' ' + word + ' Z' + word[1:]
            elif (word[0] == 'Z'):
                newline = ''
                break
            elif (word[0] == 'G'):
                newline += ' ' + word
            elif (word[0] == 'F'):
                newline += ' ' + word[0] + '350'

        if len(newline) > 0:
            newline += '\n'
        print(newline)

        num = newline.split()
        if len(num) > 1:
            with open('triangleTest.txt', 'a') as newfile: # add modified line to new file
                newfile.write(newline)

    with open('triangleTest.txt', 'a') as newfile:  # add modified line to new file
                    newfile.write('G01 X0 U0 Y0 Z0')
#write file again
# with open('newfile.txt', 'w') as file:
#   file.write(lines)
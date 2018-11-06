
#read file
with open('triangleGcode.txt', 'r+') as file:
    lines = file.readlines()
    for line in lines:
        print(type(line))
        line = line.replace('Z-1', '')
        line = line.replace('Z0.5', '')
        line = line.replace('Z0', '')

        words = line.split()
        newline = ''
        for word in words:
            if (word[0] == 'X'):
                newline = newline + ' ' + word + ' U' + word[1:]
            elif (word[0] == 'Y'):
                newline = newline + ' ' + word + ' Z' + word[1:]
            else:
                newline += ' ' + word
        newline += '\n'
        print(newline)

        with open('newfile.txt', 'a') as newfile: # add modified line to new file
            newfile.write(newline)


#write file again
# with open('newfile.txt', 'w') as file:
#   file.write(lines)

#read file
with open('boxFaceCode.txt', 'r+') as file:
    lines = file.readlines()
    for line in lines:
        setG = False

        print(type(line))

        words = line.split()
        newline = ''
        print(words)
        for index, word in enumerate(words):
            # add U motor to match X
            if (word[0] == 'X'):
                newline += ' ' + word + words[index+1] + ' U-' + words[index+1]
            # add Z motor to match Y
            elif (word[0] == 'Y'):
                newline += ' ' + word + words[index+1] + ' Z' + words[index+1]
            elif (word[0] == 'G') and not setG:
                newline += ' ' + word
                setG = True
        if len(newline) > 0:
            newline += '\n'

        num = newline.split()
        if len(num) > 1:
            with open('newfile.txt', 'a') as newfile: # add modified line to new file
                newfile.write(newline)


#write file again
# with open('newfile.txt', 'w') as file:
#   file.write(lines)
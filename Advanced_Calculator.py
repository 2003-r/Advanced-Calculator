# function declartion
import sys

def add(num1, num2):
    return num1 + num2

def subtract(num1, num2):
    return num1 - num2

def multiply(num1, num2):
    return num1 * num2

def divide(num1, num2):
    if(num2 == 0):
         return 0
    return num1 / num2

def remainder(num1, num2):
    if num2 != 0:
        return num1 % num2

def exponentiation(num1, num2):
    prod = 1
    count = 0
    if num2 > 0 or num2 == 0:
        while(count < num2):
            prod = prod * num1
            count += 1
        return prod
    return 0 #if number is not a positive integer return zero (function will only support positive integers)

def squareroot(num1):
    i = 0.0
    if num1 > 0 or num1 == 0:
       while( i*i != num1):
        i += 1
       return i
    return 0 # negative numbers does not have a real square roots

# display operation keys
print(" Key " + "\t" + " Triggers ")
print(" + " + "\t" + " Sum operation ")
print(" - " + "\t" + " Subtraction operation ")
print(" * " + "\t" + " Division operation ")
print(" / " + "\t" + " Multiplication operation ")
print(" % " + "\t" + " Reminder operation ")
print(" ^ " + "\t" + " Exponentiation function ")
print(" s " + "\t" + " Square root operation ,operation having one operand ")
print(" = " + "\t" + " Operator that triggers particular operation (above) to execute ")
print("------------------------------------------------------------------------")
print("after each input 'entry' PRESS ENTER, then Enter '=' to get the value")
print("------------------------------------------------------------------------")
print("To save a number to Mem Press M after the number")
print("if it was first Input (num1) it will be stored but no calculation afer it")
print("If M entered after the second Input, it will be stored and you can continue the calculation if you wish.")
print("To retrieve and continue with any number you want from the list Press Rn (n index of the element in the list)")
# the while to take user input then call the needed fun
firstInput = 0
num1 = 0.0
op = ''
num2 = 0.0
equal = ''
result = 0.0
Mem = []
i = 0

while(True):
    firstInput = input()

    def isfloat(num):
        try:
            float(num)
            return True
        except ValueError:
            return False

    def isint(num):
        try:
            int(num)
            return True
        except ValueError:
            return False
           
    if  isfloat(firstInput) == True:
        num1 = float(firstInput)
        op = input()
        if op == '+':
            Input2 = input()
            if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = add(num1, num2)
                    
                elif equal == 'M':
                    Mem.append(num2)
                    result = add(num1, num2)
                else:
                    equal = '='
                    result = add(num1, num2)
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = add(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = add(num1, num2)
                else:
                    equal = '='
                    result = add(num1, num2)
            print(result)
                 
        elif op == '-':
            Input2 = input()
            if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = subtract(num1, num2)

                elif equal == 'M':
                    Mem.append(num2)
                    result = subtract(num1, num2)
                else:
                    equal = '='
                    result = subtract(num1, num2)
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = subtract(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = subtract(num1, num2)
                else:
                    equal = '='
                    result = subtract(num1, num2)
            print(result)

        elif op == '*':
           Input2 = input()
           if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = multiply(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = multiply(num1, num2)
                else:
                    equal = '='
                    result = multiply(num1, num2)
           else:
                num2 = num1         
                equal = input()
                if equal == '=':
                    result = multiply(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = multiply(num1, num2)
                else:
                    equal = '='
                    result = multiply(num1, num2)
           print(result)

        elif op == '/':
           Input2 = input()
           if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = divide(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = divide(num1, num2)
                else:
                    equal = '='
                    result = divide(num1, num2)
           else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = divide(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = divide(num1, num2)
                else:
                    equal = '='
                    result = divide(num1, num2)
           print(result)

        elif op == '%':
            n1 = int(num1)
            Input2 = input()
            if isint(Input2):
                num2 = int(Input2)
                equal = input()
                if equal == '=':
                    result = remainder(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = remainder(num1, num2)
                else:
                    equal = '='
                    result = remainder(num1, num2)  
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = remainder(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = remainder(num1, num2)
                else:
                    equal = '='
                    result = remainder(num1, num2)
            print(result)

        elif op == '^':
            Inupt2 = input()
            if isint(Input2):
                num2 = int(Input2)
                equal = input()
                if equal == '=':
                    result =exponentiation (num1, num2)
                elif equal == 'M':
                    Mem.append(num2)   
                    result = exponentiation(num1, num2)
                else:
                    equal = '='
                    result = exponentiation(num1, num2)
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = exponentiation(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = exponentiation(num1, num2)
                else:
                    equal = '='
                    result = exponentiation(num1, num2)
            print(result)  

        elif op == 's': 
            equal = input()
            if equal == '=':
                result = squareroot(num1)
            elif equal == 'M':
                    Mem.append(num1)
            else:
                equal = '='
                result = squareroot(num1)
            print(result)

        elif op == 'M':
            Mem.append(num1)

        else:
            print(result)

    elif type(firstInput) == str and (firstInput == "q" or firstInput == "Q"):
       exit(0)

    elif type(firstInput) == str and (firstInput == "M"):
        Mem.append(result)

    elif (firstInput[0] == "R"):
        x = len(firstInput) 
        n = int(firstInput[1:x]) #to parse and get the element index 
        num1 = Mem[n] #get the element at that index, then continue
        op = input()
        if op == '+':
            Input2 = input()
            if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = add(num1, num2)
                    
                elif equal == 'M':
                    Mem.append(num2)
                    result = add(num1, num2)
                else:
                    equal = '='
                    result = add(num1, num2)
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = add(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = add(num1, num2)
                else:
                    equal = '='
                    result = add(num1, num2)
            print(result)

        elif op == '-':
            Input2 = input()
            if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = subtract(num1, num2)

                elif equal == 'M':
                    Mem.append(num2)
                    result = subtract(num1, num2)
                else:
                    equal = '='
                    result = subtract(num1, num2)
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = subtract(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = subtract(num1, num2)
                else:
                    equal = '='
                    result = subtract(num1, num2)
            print(result)

        elif op == '*':
           Input2 = input()
           if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = multiply(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = multiply(num1, num2)
                else:
                    equal = '='
                    result = multiply(num1, num2)
           else:
                num2 = num1         
                equal = input()
                if equal == '=':
                    result = multiply(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = multiply(num1, num2)
                else:
                    equal = '='
                    result = multiply(num1, num2)
           print(result)

        elif op == '/':
           Input2 = input()
           if isfloat(Input2):
                num2 = float(Input2)
                equal = input()
                if equal == '=':
                    result = divide(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = divide(num1, num2)
                else:
                    equal = '='
                    result = divide(num1, num2)
           else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = divide(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = divide(num1, num2)
                else:
                    equal = '='
                    result = divide(num1, num2)
           print(result)

        elif op == '%':
            n1 = int(num1)
            Input2 = input()
            if isint(Input2):
                num2 = int(Input2)
                equal = input()
                if equal == '=':
                    result = remainder(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = remainder(num1, num2)
                else:
                    equal = '='
                    result = remainder(num1, num2)  
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = remainder(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = remainder(num1, num2)
                else:
                    equal = '='
                    result = remainder(num1, num2)
            print(result)

        elif op == '^':
            Inupt2 = input()
            if isint(Input2):
                num2 = int(Input2)
                equal = input()
                if equal == '=':
                    result =exponentiation (num1, num2)
                elif equal == 'M':
                    Mem.append(num2)   
                    result = exponentiation(num1, num2)
                else:
                    equal = '='
                    result = exponentiation(num1, num2)
            else:
                num2 = num1
                equal = input()
                if equal == '=':
                    result = exponentiation(num1, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = exponentiation(num1, num2)
                else:
                    equal = '='
                    result = exponentiation(num1, num2)
            print(result)  

        elif op == 's': 
            equal = input()
            if equal == '=':
                result = squareroot(num1)
            elif equal == 'M':
                    Mem.append(num1)
            else:
                equal = '='
                result = squareroot(num1)
            print(result)

        elif op == 'M':
            Mem.append(num1)

        else:
            print(result)
       

    elif type(firstInput) == str:
        op = firstInput
        if op == '+':
            Input2 = input()
            if isfloat(Input2):
               num2 = float(Input2)
               equal = input()
               if equal == '=':
                   result = add(result,num2)
               elif equal == 'M':
                   Mem.append(num2)
                   result = add(result,num2)
               else:
                   equal = '='
                   result = add(result,num2)
            else:
                num2 = result
                equal = input()
                if equal == '=':
                   result = add(result,num2)
                elif equal == 'M':
                   Mem.append(num2)
                   result = add(result,num2)
                else:
                   equal = '='
                   result = add(result,num2)
            print(result)

        elif op == '-':
            Input2 = input()
            if isfloat(Input2):
               num2 = float(Input2)
               equal = input()    
               if equal == '=':
                   result =subtract(result,num2)
               elif equal == 'M':  
                   Mem.append(num2)
                   result = subtract(result,num2)
               else:
                   equal = '='
                   result = subtract(result,num2) 
            else:
                num2 = result
                equal = input()
                if equal == '=':
                   result =subtract(result,num2)
                elif equal == 'M':  
                   Mem.append(num2)
                   result = subtract(result,num2)
                else:
                   equal = '='
                   result = subtract(result,num2)
            print(result)

        elif op == '*':
            Input2 = input()
            if isfloat(Input2):
               num2 = float(Input2)  
               equal = input()    
               if equal == '=':
                   result =multiply(result,num2)
               elif equal == 'M':
                   Mem.append(num2)
                   result = multiply(result,num2)
               else:
                   equal = '='
                   result = multiply(result,num2)
            else:
                num2 = result
                equal = input()
                if equal == '=':
                   result =multiply(result,num2)
                elif equal == 'M':
                   Mem.append(num2)
                   result = multiply(result,num2)
                else:
                   equal = '='
                   result = multiply(result,num2)
            print(result)

        elif op == '/':
            Input2 = input()  
            if isfloat(Input2):
               num2 = float(Input2)  
               equal = input()    
               if equal == '=':
                   result =divide(result,num2)
               elif equal == 'M':
                   Mem.append(num2)
                   result = divide(result,num2)
               else:
                   equal = '='
                   result = divide(result,num2)
            else:
                num2 = result
                equal = input()
                if equal == '=':
                   result =divide(result,num2)
                elif equal == 'M':
                   Mem.append(num2)
                   result = divide(result,num2)
                else:
                   equal = '='
                   result = divide(result,num2)
            print(result)

        elif op == '%':
            nx1 = int(result)
            Input2 = input()
            if isint(Input2):
                num2 = int(Input2)
                equal = input()
                if equal == '=':
                    result = remainder(nx1,num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = remainder(nx1,num2)
                else:
                    equal = '='
                    result = remainder(nx1,num2)
            else:
                num2 = int(result)
                equal = input()
                if equal == '=':
                    result = remainder(nx1,num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = remainder(nx1,num2)
                else:
                    equal = '='
                    result = remainder(nx1,num2)
            print(result)

        elif op == '^':
            Input2 = input()
            if isint(Input2):
                num2 = int(Input2)
                equal = input()
                if equal == '=':
                    result = exponentiation(result, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = exponentiation(result,num2)
                else:
                    equal = '='
                    result = exponentiation(result,num2)
            else:
                num2 = int(result)
                equal = input()
                if equal == '=':
                    result = exponentiation(result, num2)
                elif equal == 'M':
                    Mem.append(num2)
                    result = exponentiation(result,num2)
                else:
                    equal = '='
                    result = exponentiation(result,num2)
            print(result)

        elif op == 's':
            equal = input()
            if equal == '=':
                result = squareroot(result)
            else:
                equal = '='
                result = squareroot(result)
            print(result)

        elif op == 'M':
            Mem.append(result)

        else:
            print(result)
            

    print("to display the list Enter P, to skip Press Enter ")
    dipaly = input()
    print(Mem)
        




            



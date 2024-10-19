"use strict";
const ps = require("prompt-sync");
const prompt = ps({ sigint: true });

function add(num1, num2) {
    return num1 + num2;
}

function subtract(num1, num2) {
    return num1 - num2;
}

function multiply(num1, num2) {
    return num1 * num2;
}

function divide(num1, num2) { // if divisor is equal zero it will return infinity
    return num1 / num2;
}

function remainder(num1, num2) { // if divisor will equal zero , remainder n undefined 'Nan' 
    return num1 % num2;
}

function exponentiation(num1, num2) {
    var product = 1;
    var count = 0;
    if (num2 >= 0) {
        while (count < num2) {
            product = product * num1;
            count++;
        }
        return product;
    }
    return 0; // if number is not a positive integer return zero (function will only support positive integers)
}

function squareroot(num1) {
    var i = 0;
    if (num1 >= 0) {
        while (i * i != num1) {
            i++;
        }
        return i;
    }
    else {
        console.log("MATH ERROR");
        return 0; // negative numbers does not have a real square roots
    }

}

console.log(" Key \t Triggers ");
console.log(" + \t Sum operation");
console.log(" - \t Subtraction operation");
console.log(" * \t Division operation ");
console.log(" / \t Multiplication operation ");
console.log(" % \t Reminder operation ");
console.log(" ^ \t Exponentiation function ");
console.log(" s \t Square root operation ,operation having one operand");
console.log(" = \t Operator that triggers particular operation (above) to execute ");
console.log("----------------------------------------------------------------------");
console.log("after each input 'entry' PRESS ENTER, then Enter '=' to get the value");
console.log("----------------------------------------------------------------------");

var result = 0;
var firstInput;
var secInput;
var num1;
var num2;
var op;
var eq;
const Mem = [];
var fl;

while (true) {
    firstInput = prompt();
    if (!isNaN(firstInput)) {
        num1 = parseFloat(firstInput);
        op = prompt();
        switch (op) {
            case '+':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = add(num1, num2);
                    } else {
                        equal = '=';
                        result = add(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = add(num1, num2);
                    } else {
                        equal = '=';
                        result = add(num1, num2);
                    }
                }  
                console.log(result);
                break;

            case '-':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = subtract(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = subtract(num1, num2);
                    } else {
                        equal = '=';
                        result = subtract(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = subtract(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = subtract(num1, num2);
                    } else {
                        equal = '=';
                        result = subtract(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '*':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = multiply(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = multiply(num1, num2);
                    } else {
                        equal = '=';
                        result = multiply(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = multiply(num1, num2);
                    } else {
                        equal = '=';
                        result = multiply(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '/':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = divide(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = divide(num1, num2);
                    } else {
                        equal = '=';
                        result = divide(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = divide(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = divide(num1, num2);
                    } else {
                        equal = '=';
                        result = divide(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '%':
                var nx1 = parseInt(num1)
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseInt(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = remainder(nx1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = remainder(nx1, num2);
                    } else {
                        eq = '=';
                        result = remainder(nx1, num2);
                    }
                } else {
                    num2 = nx1;
                    eq = prompt();
                    if (eq == '=') {
                        result = remainder(nx1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = remainder(nx1, num2);
                    } else {
                        eq = '=';
                        result = remainder(nx1, num2);
                    }
                }
                console.log(result);
                break;

            case '^':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseInt(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = exponentiation(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = exponentiation(num1, num2);
                    } else {
                        eq = '=';
                        result = exponentiation(num1, num2);
                    }
                } else {
                    num2 = nx1;
                    eq = prompt();
                    if (eq == '=') {
                        result = exponentiation(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = exponentiation(num1, num2);
                    } else {
                        eq = '=';
                        result = exponentiation(num1, num2);
                    }
                }
                console.log(result);
                break;
                
            case 's':
                eq = prompt();
                if (eq == '=') {
                    result = squareroot(num1);
                    console.log(result);
                } else {
                    eq = '=';
                    result = squareroot(num1);
                    console.log(result);
                }
                break;

            case 'M':
                Mem.push(num1);
                break;

            default:
                console.log(result);
                break;
        }
    }
    else if (isNaN(firstInput) && (firstInput == 'q' || firstInput == 'Q')) {
        break;
    }
    else if (isNaN(firstInput) && (firstInput == 'M')) {
        Mem.push(result);
    }
    else if ((fl = firstInput.charAt(0)) == "R") {
        var x = (firstInput.length);
        var n = parseInt(firstInput.substring(1, x));
        num1 = Mem[n];
        op = prompt();
        switch (op) {
            case '+':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = add(num1, num2);
                    } else {
                        equal = '=';
                        result = add(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = add(num1, num2);
                    } else {
                        equal = '=';
                        result = add(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '-':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = subtract(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = subtract(num1, num2);
                    } else {
                        equal = '=';
                        result = subtract(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = subtract(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = subtract(num1, num2);
                    } else {
                        equal = '=';
                        result = subtract(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '*':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = multiply(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = multiply(num1, num2);
                    } else {
                        equal = '=';
                        result = multiply(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = multiply(num1, num2);
                    } else {
                        equal = '=';
                        result = multiply(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '/':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = divide(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = divide(num1, num2);
                    } else {
                        equal = '=';
                        result = divide(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = divide(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = divide(num1, num2);
                    } else {
                        equal = '=';
                        result = divide(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '%':
                var nx1 = parseInt(num1)
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseInt(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = remainder(nx1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = remainder(nx1, num2);
                    } else {
                        eq = '=';
                        result = remainder(nx1, num2);
                    }
                } else {
                    num2 = nx1;
                    eq = prompt();
                    if (eq == '=') {
                        result = remainder(nx1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = remainder(nx1, num2);
                    } else {
                        eq = '=';
                        result = remainder(nx1, num2);
                    }
                }
                console.log(result);
                break;

            case '^':
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseInt(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = exponentiation(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = exponentiation(num1, num2);
                    } else {
                        eq = '=';
                        result = exponentiation(num1, num2);
                    }
                } else {
                    num2 = nx1;
                    eq = prompt();
                    if (eq == '=') {
                        result = exponentiation(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = exponentiation(num1, num2);
                    } else {
                        eq = '=';
                        result = exponentiation(num1, num2);
                    }
                }
                console.log(result);
                break;

            case 's':
                eq = prompt();
                if (eq == '=') {
                    result = squareroot(num1);
                    console.log(result);
                } else {
                    eq = '=';
                    result = squareroot(num1);
                    console.log(result);
                }
                break;

            case 'M':
                Mem.push(num1);
                break;

            default:
                console.log(result);
                break;
        }
    }
    else {
        op = firstInput;
        switch (op) {
            case '+':
                num1 = result;
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = add(num1, num2);
                    } else {
                        equal = '=';
                        result = add(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = add(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = add(num1, num2);
                    } else {
                        equal = '=';
                        result = add(num1, num2);
                    }
                }
                console.log(result);
                break;
                

            case '-':
                num1 = result;
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = subtract(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = subtract(num1, num2);
                    } else {
                        equal = '=';
                        result = subtract(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = subtract(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = subtract(num1, num2);
                    } else {
                        equal = '=';
                        result = subtract(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '*':
                num1 = result;
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = multiply(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = multiply(num1, num2);
                    } else {
                        equal = '=';
                        result = multiply(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = multiply(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = multiply(num1, num2);
                    } else {
                        equal = '=';
                        result = multiply(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '/':
                num1 = result;
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseFloat(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = divide(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = divide(num1, num2);
                    } else {
                        equal = '=';
                        result = divide(num1, num2);
                    }
                } else {
                    num2 = num1;
                    eq = prompt();
                    if (eq == '=') {
                        result = divide(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = divide(num1, num2);
                    } else {
                        equal = '=';
                        result = divide(num1, num2);
                    }
                }
                console.log(result);
                break;

            case '%':
                var nx1 = parseInt(result)
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseInt(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = remainder(nx1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = remainder(nx1, num2);
                    } else {
                        eq = '=';
                        result = remainder(nx1, num2);
                    }
                } else {
                    num2 = nx1;
                    eq = prompt();
                    if (eq == '=') {
                        result = remainder(nx1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = remainder(nx1, num2);
                    } else {
                        eq = '=';
                        result = remainder(nx1, num2);
                    }
                }
                console.log(result);
                break;

            case '^':
                num1 = result;
                secInput = prompt();
                if (!isNaN(secInput)) {
                    num2 = parseInt(secInput);
                    eq = prompt();
                    if (eq == '=') {
                        result = exponentiation(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = exponentiation(num1, num2);
                    } else {
                        eq = '=';
                        result = exponentiation(num1, num2);
                    }
                } else {
                    num2 = nx1;
                    eq = prompt();
                    if (eq == '=') {
                        result = exponentiation(num1, num2);
                    } else if (eq == 'M') {
                        Mem.push(num2);
                        result = exponentiation(num1, num2);
                    } else {
                        eq = '=';
                        result = exponentiation(num1, num2);
                    }
                }
                console.log(result);
                break;

            case 's':
                num1 = result;
                eq = prompt();
                if (eq == '=') {
                    result = squareroot(num1);
                    console.log(result);
                } else {
                    eq = '=';
                    result = squareroot(num1);
                    console.log(result);
                }
                break;
               
            case 'M':
                Mem.push(result);
                break;

            default:
                console.log();
                break;
        }

    }

    var list;
    console.log("To List the saved numbers Press P, To skip Press Enter");
    list = prompt();
    if (list == 'P') {
        console.log(Mem);
    }
}

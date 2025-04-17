module FunctionalProgramming.WorkWithNumbers

let rec gcd a b = 
     if b = 0 then a
     else gcd b (a % b)

let eulerPhi num =
     let rec helper current acc =
         if current = 0 then acc
         else
             let newAcc =
                 if gcd num current = 1 then acc + 1
                 else acc
             helper (current - 1) newAcc
     helper (num - 1) 0
let eulerNum = 5
System.Console.WriteLine($"Число Эйлера для {eulerNum} = {eulerPhi eulerNum}")

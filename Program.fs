let sumOfDigits n=
    let rec sumDigits n curSum =
        if n = 0 then curSum
         else
             let n1 = n/10
             let cifr = n%10
             let newSum = curSum + cifr
             sumDigits n1 newSum
    sumDigits n 0

let main () =
    printf "Введите число: "
    let number = System.Console.ReadLine() |> int
    let sum = sumOfDigits number
    System.Console.WriteLine(sum)

main ()

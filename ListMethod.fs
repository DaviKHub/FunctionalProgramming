module FunctionalProgramming.ListMethod

let rec readList n =
    if n = 0 then
        []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = readList (n - 1)
        Head :: Tail

let readData =
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList =
    function
    | [] ->
        let z = System.Console.ReadKey()
        0
    | (head: int) :: tail ->
        System.Console.WriteLine(head)
        writeList tail

let max2 x y = if x > y then x else y

let rec accCond list (f: int -> int -> int) p acc =
    match list with
    | [] -> acc
    | h :: t ->
        let newAcc = f acc h
        if p h then accCond t f p newAcc else accCond t f p acc

let listMin list =
    match list with
    | [] -> 0
    | h :: t -> accCond list (fun x y -> if x < y then x else y) (fun x -> true) h

let listMax list =
    match list with
    | [] -> 0
    | h :: t -> accCond list max2 (fun x -> true) h

let listSum list =
    accCond list (fun x y -> x + y) (fun x -> true) 0

let listPr list =
    accCond list (fun x y -> x * y) (fun x -> true) 1

let rec frequency list elem count =
    match list with
    | [] -> count
    | h :: t ->
        let count1 = count + 1

        if h = elem then
            frequency t elem count1
        else
            frequency t elem count

let rec freqList list mainList curList =
    match list with
    | [] -> curList
    | h :: t ->
        let freqElem = frequency mainList h 0
        let newList = curList @ [ freqElem ]
        freqList t mainList newList

let pos list el =
    let rec pos1 list el num =
        match list with
        | [] -> 0
        | h :: t ->
            if (h = el) then
                num
            else
                let num1 = num + 1
                pos1 t el num1

    pos1 list el 1

let getIn list pos =
    let rec getIn1 list num curNum =
        match list with
        | [] -> 0
        | h :: t ->
            if num = curNum then
                h
            else
                let newNum = curNum + 1
                getIn1 t num newNum

    getIn1 list pos 1

let filter list pr =
    let rec filter1 list pr newList =
        match list with
        | [] -> newList
        | h :: t ->
            let newnewList = newList @ [ h ]

            if pr h then
                filter1 list pr newnewList
            else
                filter1 list pr newList

    filter1 list pr []

let even n = ((n % 2) = 0)

let delEL list el = filter list (fun x -> (x <> el))

let uniq list =
    let rec uniq1 list newList =
        match list with
        | [] -> newList
        | h :: t ->
            let listWithout = delEL t h
            let newnewList = newList @ [ h ]
            uniq1 listWithout newnewList

    uniq1 list []
    
let rec cifrSum n =
    if n = 0 then 0 else (n % 10) + (cifrSum (n / 10))
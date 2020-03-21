open System

stdin.ReadLine()

let A = stdin.ReadLine().Split() |> Array.map int

let rec count x = if x % 2 = 0 then 1 + count (x / 2) else 0

let r = A |> Array.map count |> Array.min

printfn "%d" r
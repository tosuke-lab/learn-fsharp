open System

let [|a; b|] = stdin.ReadLine().Split() |> Array.map int

let (|Even|Odd|) x = if x % 2 = 0 then Even else Odd

match (a*b) with
| Even -> printfn "Even"
| Odd -> printfn "Odd"
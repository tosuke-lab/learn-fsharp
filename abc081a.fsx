open System

let r = stdin.ReadLine() |> Seq.filter ((=) '1') |> Seq.length
printfn "%d" r
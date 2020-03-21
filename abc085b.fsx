open System

let readInt () = stdin.ReadLine() |> int

let N = readInt ()
let d = [| for _ in 1..N -> readInt () |]

let result =
  d
  |> Array.distinct
  |> Array.length

printfn "%d" result
open System

let a = stdin.ReadLine() |> int
let (b, c) =
  let arr = stdin.ReadLine().Split() |> Array.map int
  match arr with
    | [|b; c|] -> (b, c)
    | _ -> failwith "owatta"

let s = stdin.ReadLine()

printfn "%d %s" (a+b+c) s
open System

let readInt () = stdin.ReadLine() |> int
let readInts () = stdin.ReadLine().Split() |> Array.map int

let pair = function
| [|a; b|] -> (a, b)
| _ -> failwith "owatta"

let triple = function
| [|a; b; c|] -> (a, b, c)
| _ -> failwith "owatta"

let optionDefault defaultValue opt = if Option.isSome(opt) then Option.get opt else defaultValue

let N = readInt ()
let path = seq {
  for _ in 1..N -> readInts() |> triple
}

path
|> Seq.scan (fun (_, (pt, px, py)) (t, x, y) ->
  let cost = abs(x - px) + abs(y - py)
  let time = t - pt
  (cost <= time && abs(time - cost) % 2 = 0, (t, x, y))
) (true, (0, 0, 0))
|> Seq.forall (fun (f, _) -> f)
|> (fun f -> if f then "Yes" else "No")
|> printfn "%s"

open System

let readInt () = stdin.ReadLine() |> int
let readInts () = stdin.ReadLine().Split() |> Array.map int

let pair = function
| [|a; b|] -> (a, b)
| _ -> failwith "owatta"

let optionDefault defaultValue opt = if Option.isSome(opt) then Option.get opt else defaultValue


let S = stdin.ReadLine()

let reverse (s: string) =
  let arr = s.ToCharArray()
  Array.Reverse arr
  String.Concat arr

let candi = ["dream"; "dreamer"; "erase"; "eraser"] |> List.map reverse

let rec cond (s: string) =
  if s.Length = 0
  then true
  else
    List.tryFind (fun (c: string) -> s.Length >= c.Length && s.[..(c.Length - 1)] = c) candi
    |> function
    | Some(c) -> cond s.[c.Length..]
    | None -> false

S
|> reverse
|> cond
|> function
| true -> "YES"
| false -> "NO"
|> printfn "%s"
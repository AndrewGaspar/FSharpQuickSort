namespace AndrewGaspar

module QuickSort = 
    let rec quick list =
        match list with 
        | ([] | [_]) -> list
        | head::tail -> let lesser, greater = List.partition((>=) head) tail
                        quick lesser @ [head] @ quick greater
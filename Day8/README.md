## 認識 Func<T, T>
* 看懂 Func 語法

* 先使用 Func 建立一個方法
* 製作 Where 

練習
* Method => Func => 泛型 => 擴充方法

## 匿名型別
匿名類型提供一個便利的方法，將一組唯讀屬性封裝成一個物件，而不需要事先明確定義類型。 類型名稱會由編譯器產生，並且無法在原始程式碼層級使用。

### 參考:
[匿名類型 (C# 程式設計手冊)](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/anonymous-types)

## Language Integrated Query (LINQ)
常用 LINQ API
| Operator   | Description   |
|---|---|
| [Where](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.where?view=netframework-4.8)   |  Returns values from the collection based on a predicate function |
| [Select](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.select?view=netframework-4.8), [SelectMany](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.selectmany?view=netframework-4.8)  | The Select operator always returns an IEnumerable collection which contains elements based on a transformation function  |
| [FirstOrDefault](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.firstordefault?view=netframework-4.8), [First](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.first?view=netframework-4.8) | The First and FirstOrDefault method returns an element from the zeroth index in the collection i.e. the first element. Also, it returns an element that satisfies the specified condition   |
| [All](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.all?view=netframework-4.8)   | Checks if all the elements in a sequence satisfies the specified condition.  |
| [Any](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.any?view=netframework-4.8)  | Checks if any of the elements in a sequence satisfies the specified condition  |
| [Contains](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.contains?view=netframework-4.8)  | The Contains operator checks whether a specified element exists in the collection or not and returns a boolean.  |
| [GroupBy](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.groupby?view=netframework-4.8)  | The GroupBy operator returns groups of elements based on some key value. Each group is represented by IGrouping<TKey, TElement> object.   |
| [OrderBy](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.orderby?view=netframework-4.8), [OrderByDescending](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.orderbydescending?view=netframework-4.8) |  Sorts the elements in the collection based on specified fields in ascending or decending order. |
| [ThenBy](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.thenby?view=netframework-4.8), [ThenByDescending](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.thenbydescending?view=netframework-4.8)  | The OrderBy() method sorts the collection in ascending order based on specified field. Use ThenBy() method after OrderBy to sort the collection on another field in ascending order  |
| [Average](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.average?view=netframework-4.8)  | Average extension method calculates the average of the numeric items in the collection. |
| [Distinct](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.distinct?view=netframework-4.8)  | Returns distinct values from a collection.  |
| [Skip](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.skip?view=netframework-4.8)  | Skips elements up to a specified position starting from the first element in a sequence.  |
| [Take](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.take?view=netframework-4.8)  | Partitioning operators split the sequence (collection) into two parts and returns one of the parts.  |
| [Count](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.count?view=netframework-4.8)  | The Count operator returns the number of elements in the collection or number of elements that have satisfied the given condition.   |
| [ToList](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.tolist?view=netframework-4.8)  | Use ToList to force immediate query evaluation and return a List<T> that contains the query results  |


### 參考
[LINQ Tutorial](https://www.tutorialsteacher.com/linq/linq-tutorials)
[LINQ APIs](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable?view=netframework-4.8)


## List VS IEnumerable
更改值後的比較
[LINQ Deferred Execution](https://www.tutorialsteacher.com/linq/linq-deferred-execution)
延遲執行的特性說明

[快快樂樂學LINQ系列前哨戰－延遲執行 (Deferred Execution)](https://dotblogs.com.tw/hatelove/archive/2013/09/10/csharp-linq-deferred-execution-introduction.aspx)


### 參考


## 推薦工具
* [LINQPad](https://www.linqpad.net/)
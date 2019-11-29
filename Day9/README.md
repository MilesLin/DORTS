## LINQ Query Syntax
``` C#

var filteredResult = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    select s.StudentName;

```

## 使用 LINQ 操作資料庫

**查詢資料**
``` C#
var _db = new DBContext()
var result = _db.Employee
            .Where(x => x.Name.Contains("Bob"));
```
**新增資料**
``` C#
var _db = new DBContext()
var emp = new Employee
{
    Name = name
};
_db.Employee.Add(emp);
_db.SaveChanges();
```
**編輯資料**
``` C#
var _db = new DBContext()
Employee employee = _db.Employee.FirstOrDefault(x => x.Id == 1);
employee.Name = name;
_db.SaveChanges();
```

**刪除資料**
``` C#
var _db = new DBContext()
Employee employee = _db.Employee.FirstOrDefault(x => x.Id == 1);
_db.Employee.Remove(employee);
_db.SaveChanges();
```

### 參考:
[Entity Framework 總覽](https://docs.microsoft.com/zh-tw/dotnet/framework/data/adonet/ef/overview)

## 使用 LINQ 撰寫 JOIN 語法
``` C#
using (DBContext db = new DBContext())
{
    // Method Syntax
    var data = db.Role
        .Join(
            db.Account,
            role => role.Id,
            acct => acct.RoleId,
            (role, acct) => new
            {
                RoleName = role.Name,
                AcctName = acct.Name
            }).ToList();

    // Query Syntax
    var innerJoin = from r in db.Role
                    join a in db.Account
                    on r.Id equals a.RoleId
                    select new
                    {
                        RoleName = r.Name,
                        AcctName = a.Name
                    };
}
```

### 參考
* [Left Join and Inner Join](https://dotblogs.com.tw/mileslin/2016/03/02/011824)
* [Joining Operator: Join](https://www.tutorialsteacher.com/linq/linq-joining-operator-join)
* [Joining Operator: GroupJoin](https://www.tutorialsteacher.com/linq/linq-joining-operator-groupjoin)



## 使用 LINQ 查詢 XML 資料
建議使用序列化的方式處理 XML 的資料
``` C#

XmlSerializer deserializer = new XmlSerializer(typeof(Person));
using (TextReader reader = new StringReader(xml))
{
    object deserializationObj = deserializer.Deserialize(reader);

    var p = deserializationObj as Person;

    var pResult = p.學生.Where(x => x.學號 == 9096007).FirstOrDefault();
    System.Console.WriteLine($"{pResult.姓名}: {pResult.學號}");

};

```
**範例 XML**
``` XML

<?xml version="1.0" encoding="utf-8"?>
<Person>
  <學生>
    <學號>9096036</學號>
    <姓名>蔡文龍</姓名>
    <電話>04-32345671</電話>
    <信箱>wltasi@yahoo.com.tw</信箱>
  </學生>
  <學生>
    <學號>9096001</學號>
    <姓名>許百宏</姓名>
    <電話>04-12345671</電話>
    <信箱>em@ms37.hient.net</信箱>
  </學生>
</Person>

```

### 參考
* [XML 序列化與反序列化](https://dotblogs.com.tw/mileslin/2016/09/23/014923)
* [[VisualStudio] Paste Special - 將 Json 或 XML 文字轉換為 C# 類別物件](https://marcus116.blogspot.com/2019/02/visualstudio-paste-special-json-xml-c.html)


## PLINQ 簡介 (Parallel LINQ)
可以平行處理大量資料的 API。

``` C#
var numbers = Enumerable.Range(1, 10).ToList();

var data = numbers.AsParallel().Select(x =>
{    
    return Math.Sqrt(x);
});

```

### 參考
* [平行 LINQ (PLINQ)](https://docs.microsoft.com/zh-tw/dotnet/standard/parallel-programming/parallel-linq-plinq)
* [PLINQ 點部落](https://dotblogs.com.tw/mileslin/tags/1?qq=PLINQ)
* [PARALLEL PROGRAMMING](http://www.albahari.com/threading/part5.aspx)


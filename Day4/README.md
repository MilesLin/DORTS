chapter 3:
複習，說明上次作業的程式碼

chapter 5:

## 說明什麼是類別(Class)與實體(Instance)
* 使用物件的方法
* 如何建立單純是資料的物件
* 


## static 說明 (Day6 說明)
private
protected
public

## 抽象類別
使用讀取資料來源(txt vs csv)



## 介面
* 如何定義介面
* 食物外送的運費計算器
* fixture 自定義介面擴充的方法
  * 先請大家練習 fixture 怎麼使用
* 

## 泛型
* 製作泛型的加減乘除

## List 與 Array
 * List 底層就是 Array
 * 以後用 List 就好

## 物件
5-16 dynamic binding
static binding
In the most general terms, static binding means that references are resolved at compile time.

``` C#
Animal a = new Animal();
a.Roar(); // The compiler can resolve this method call statically.
``` 
Dynamic binding means that references are resolved at run time.

``` C#
public void MakeSomeNoise(object a) {
   // Things happen...
   ((Animal) a).Roar(); // You won't know if this works until runtime!
}
```
https://stackoverflow.com/questions/640974/what-is-the-difference-between-static-and-dynamic-binding#targetText=In%20the%20most%20general%20terms,%7B%20%2F%2F%20Things%20happen...


<!-- 可以講 using -->

可以講一個 class 裡面能夠有哪些成員
方法
欄位
屬性
等等之類的

命名規則

* 命名空間如何分
* 可以建立加密還有解密的類別
* 製作一個撲克牌的荷官類別
  * 擁有荷官姓名(屬性)
  * 發牌的方法
  * 洗牌的方法
  * 負責發牌、洗牌


說明 fixture 也是用物件導向的方式來設計

Day5: 題目=> 請用物件導向的方式，計算不同物流的金額

存取修飾詞

Partial Classes (可考慮不說)

製作
加密解密的類別
寄 MAIL 的類別

類別與實體的差別

課本的題目
定義一個Emplyee員工類別，該類別的成員如下：
 Salary薪水屬性：可用設定員工薪水，最小值20000，最大值40000。
 Ename欄位：用來設定員工的姓名。
 PrintData()方法：顯示員工的姓名，薪水資訊。
 ShowError()事件：當員工Salary薪水屬性設定錯誤時，會觸發此事件，並顯示"薪水必須介於20,000到40,000之間"。

## 說明 LIST(day 5)

seal 可考慮說明

講解介面的時候可以說明，fixture API 設計的方式

儲存資料的物件，以 Entity Framework 產生的程式碼為例

https://dotblogs.com.tw/mileslin/2015/12/17/234912

https://dotblogs.com.tw/mileslin/2015/12/22/010452

https://dotblogs.com.tw/mileslin/2015/12/23/011128
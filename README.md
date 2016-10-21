Задание 1.

Написать реализацию заполнения дерева объектов из плоской таблицы без использования рекурсии. Таблица вида talbe1 { Id, ParentId }

Код необходимо написать на С#.

 

 

Задание 2.

 

Написать приложение, которое превращает экземпляр объекта типа Test в XML-строку.

Описание объекта:

             public class Test

             {

                    public string Id { get; set; }

                    public long? Count { get; set; }

                    public string Name { get; set; }

public int? Number { get; set; }              

             }

 Дополнительно, не передавать в строку параметр (тег), если его значение == null или пустой строке. 

Т.е для объекта var t = new Test() {Id = "1", Number = 1};

Пакет должен быть приблизительно таким:

 

<?xml version="1.0" encoding="utf-16"?>

<Test xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">

<Id>1</Id>

<Number>1</Number>

</Test>
������� 1.

�������� ���������� ���������� ������ �������� �� ������� ������� ��� ������������� ��������. ������� ���� talbe1 { Id, ParentId }

��� ���������� �������� �� �#.

 

 

������� 2.

 

�������� ����������, ������� ���������� ��������� ������� ���� Test � XML-������.

�������� �������:

             public class Test

             {

                    public string Id { get; set; }

                    public long? Count { get; set; }

                    public string Name { get; set; }

public int? Number { get; set; }              

             }

 �������������, �� ���������� � ������ �������� (���), ���� ��� �������� == null ��� ������ ������. 

�.� ��� ������� var t = new Test() {Id = "1", Number = 1};

����� ������ ���� �������������� �����:

 

<?xml version="1.0" encoding="utf-16"?>

<Test xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">

<Id>1</Id>

<Number>1</Number>

</Test>
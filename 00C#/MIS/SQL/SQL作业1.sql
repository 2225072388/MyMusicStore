use onelibrary

--	查询TBL_Bookinfo 表中所有图书的索取号,标准编号,书名。
SELECT [BookID] as 索取号
      ,[ISBN] as 标准编号
      ,[BookName] as 书名
FROM [TBL_BookInfo]

--	在TBL_BookInfo显示书名中有”工程”两个字的图书的书名,出版社,作者及出版日期。
SELECT [BookName] as 书名
      ,[Publisher] as 出版社
      ,[Author] as  作者
      ,[PublishDate]as  出版日期     
FROM [TBL_BookInfo]
WHERE [BookName] like '%工程%'

--	在TBL_BookInfo中找出书名中带有“学”字，但又不带有“中学”二字的书
SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [bookname] like '%学%'  and [bookname] not like '%中%学%'

--	在TBL_BookInfo中找出页数大于100页并且小于200页的书（分别用比较运算符和BETWEEN两种方法实现）
SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [PageCount] between 101 and 199

SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [PageCount] > 100 and [PageCount] <200

--	查询TBL_Bookinfo 表中所有图书的索取号,标准编号,书名，并用中文显示列名。
SELECT [BookID] as 索取号
      ,[ISBN] as 标准编号
      ,[BookName] as 书名
FROM [TBL_BookInfo]

--	在TBL_Bookinfo 表中查询所有“清华大学出版社”出版的书的书名, 作者及出版日期。
SELECT [BookName] as 书名
      ,[Author] as  作者
      ,[PublishDate]as  出版日期     
FROM [TBL_BookInfo]
WHERE [Publisher] = '清华大学出版社'

--	从TBL_Bookinfo表中检索出不是电子工业出版社和清华大学出版社出版的图书。
SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [Publisher] <> '清华大学出版社' and [Publisher] <> '电子工业出版社'

SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [Publisher] not in('清华大学出版社','电子工业出版社')

--	在TBL_Bookinfo显示“中国古代教育文选”和“德国近代文学史”两本书的信息。
SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [BookName] = '中国古代教育文选' or [BookName] = '德国近代文学史'

SELECT [BookID]
      ,[ISBN]
      ,[BookName]
      ,[Author]
      ,[PublishDate]
      ,[BookVersion]
      ,[WordCount]
      ,[PageCount]
      ,[Publisher]
      ,[ClassID]
  FROM [TBL_BookInfo]
WHERE [BookName] in('中国古代教育文选','德国近代文学史')

--	在TBL_Bookinfo显示“清华大学出版社”在1980后出版图书的书名，作者，页数。
SELECT [BookName] as 书名
      ,[Author] as 作者
      ,[PageCount] as 页数
  FROM [TBL_BookInfo]
WHERE [Publisher] ='清华大学出版社' and [PublishDate]>'1979-12-31'

--	在TBL_User表中中找出不姓“蒋”并且名字是3个字的男生
SELECT [UserID]
      ,[UserName]
      ,[Sex]
      ,[Password]
      ,[Email]
      ,[Class]
      ,[photo]
  FROM [TBL_User]
where Username like '[^蒋]__' and [sex]=1
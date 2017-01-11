insert into ReportModels Values (1,'Farm 1',getdate())

insert into ReportModels Values (1,'Farm 2' ,getdate())

insert into ReportModels Values (2,'Farm 1' ,getdate())

insert into RepQuestionModels values (1,1,1)
insert into RepQuestionModels values (2,1,1)
insert into RepQuestionModels values (3,1,1)

select * from ReportModels

1	1	1	1
2	2	1	1
3	3	1	1

SELECT 
    [Extent1].[ID] AS [ID], 
    [Extent1].[UserID] AS [UserID], 
    [Extent1].[ReportFarmName] AS [ReportFarmName], 
    [Extent1].[ReportDateTime] AS [ReportDateTime]
    FROM [dbo].[ReportModels] AS [Extent1]
/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [StudentId]
      ,[FirstName]
      ,[LastName]
	  ,[Age]
	  ,[Suburb]
	  ,[TownOrCity]
	  ,[LessonName]
	  ,[Instrument]
	  ,[LessonFeesOwed]
	  ,[InstrumentFeesOwed]
	  ,([LessonFeesOwed] + [InstrumentFeesOwed]) AS "TotalFeesOwed"
  FROM [attfire1_assignment2.MusicClassesContext].[dbo].[People]
  JOIN [attfire1_assignment2.MusicClassesContext].[dbo].[Students] 
  ON [People].[PersonId] = [Students].[PersonPersonId] 
  JOIN [attfire1_assignment2.MusicClassesContext].[dbo].[StudentLessons]
  ON [StudentLessons].[StudentStudentId] = [Students].[StudentId]
  JOIN [attfire1_assignment2.MusicClassesContext].[dbo].[Lessons]
  ON [StudentLessons].[LessonLessonId] = [Lessons].[LessonId]
  JOIN [attfire1_assignment2.MusicClassesContext].[dbo].[Addresses] 
  ON [People].[AddressAddressId] = [Addresses].[AddressId] 
  JOIN [attfire1_assignment2.MusicClassesContext].[dbo].[Instruments]
  ON [Students].[InstrumentInstrumentId] = [Instruments].[InstrumentId];
  
  
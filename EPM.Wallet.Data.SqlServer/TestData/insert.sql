USE [wallet]
DELETE FROM [Cards]
DELETE FROM [ClientAccounts]
DELETE FROM [Messages]
DELETE FROM [Requisites]
DELETE FROM [BankAccounts]
DELETE FROM [Banks]
DELETE FROM [Clients]
DELETE FROM [ClientAccountStatuses]
DELETE FROM [Currencies]
GO

/* Currencies */
INSERT INTO [Currencies] ([Id]) VALUES ('USD')
INSERT INTO [Currencies] ([Id]) VALUES ('EUR')

/* ClientAccountStatuses */
INSERT INTO [ClientAccountStatuses] ([Id], [Name]) VALUES ('NEW', 'new client account')
INSERT INTO [ClientAccountStatuses] ([Id], [Name]) VALUES ('CLOSE', 'closed client account')

/* Clients */
INSERT INTO [Clients] ([Id], [Name]) VALUES ('TUSRA', 'TEST USER A')
INSERT INTO [Clients] ([Id], [Name]) VALUES ('TUSRB', 'TEST USER B')

/* Banks */
INSERT INTO [Banks] ([Id], [Name]) VALUES ('{44074D76-09B5-49C7-A458-82121F37585C}', 'RBS')
INSERT INTO [Banks] ([Id], [Name]) VALUES ('{7357449A-0494-439C-BF41-E20F9229B6A3}', 'BOV')

/* BankAccounts */
INSERT INTO [BankAccounts]
           ([Id]
           ,[Name]
           ,[BankId]
           ,[CurrencyId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{B2916046-5865-423C-997A-038DDC7AFAFB}'
           ,'RBS USD'
           ,'{44074D76-09B5-49C7-A458-82121F37585C}'
           ,'USD'
           ,'20170201 6:30'
           ,'20170203 7:00'
           ,'testa'
           ,'testb')
INSERT INTO [BankAccounts]
           ([Id]
           ,[Name]
           ,[BankId]
           ,[CurrencyId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{D6ECCB72-4DCF-4A2C-B224-9263C3DC6D29}'
           ,'RBS EUR'
           ,'{44074D76-09B5-49C7-A458-82121F37585C}'
           ,'EUR'
           ,'201702004 8:30'
           ,'20170205 9:00'
           ,'testb'
           ,'testa')
INSERT INTO [BankAccounts]
           ([Id]
           ,[Name]
           ,[BankId]
           ,[CurrencyId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{0D3476B3-9302-49F4-89E7-47109070D6D8}'
           ,'BOV EUR'
           ,'{7357449A-0494-439C-BF41-E20F9229B6A3}'
           ,'EUR'
           ,'20170201 8:30'
           ,'20170205 10:00'
           ,'testb'
           ,'testa')

/* ClientRequsites */
INSERT INTO [Requisites]
           ([Id]
           ,[Name]
           ,[ClientId]
           ,[BankName]
           ,[Iban]
		   ,[IsVisible])
     VALUES
           ('{A8D84ECF-BCC3-4785-AB5A-AF1557982E11}'
           ,'TUSRA Requsite 01'
           ,'TUSRA'
           ,'TUSRA Requsite 01 BankName'
           ,'TUSRA Requsite 01 Iban'
		   , 1)
INSERT INTO [Requisites]
           ([Id]
           ,[Name]
           ,[ClientId]
           ,[BankName]
           ,[Iban]
		   ,[isVisible])
     VALUES
           ('{D3D9AB6D-A032-4B79-8D95-B8C11AA5D0E2}'
           ,'TUSRB Requsite 01'
           ,'TUSRB'
           ,'TUSRB Requsite 01 BankName'
           ,'TUSRB Requsite 01 Iban'
		   ,1)

/* ClientMessages */
INSERT INTO [Messages]
           ([Id]
           ,[Subject]
           ,[Body]
           ,[ClientId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy]
		   ,[ReadDate]
		   ,[DeletionDate]
		   ,[IsOutgoing])
     VALUES
           ('{BA9216BF-975A-49A5-AD76-A6DF05077038}'
           ,'TUSRA subject 01'
           ,'TUSRA body 01'
           ,'TUSRA'
           ,'20170205 17:05'
           ,'20170205 17:05'
           ,''
           ,''
		   ,null
		   ,null
		   ,0)
INSERT INTO [Messages]
           ([Id]
           ,[Subject]
           ,[Body]
           ,[ClientId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy]
		   ,[ReadDate]
		   ,[DeletionDate]
		   ,[IsOutgoing])
     VALUES
           ('{6ED5AF3C-BA8F-496F-B080-90F3F1F1B533}'
           ,'TUSRA subject 02'
           ,'TUSRA body 02'
           ,'TUSRA'
           ,'20170207 10:05'
           ,'20170207 10:05'
           ,''
           ,''
		   ,null
		   ,null
		   ,0)

/* ClientAccounts */
INSERT INTO [ClientAccounts]
           ([Id]
           ,[Name]
           ,[CurrencyId]
           ,[ClientId]
           ,[BankAccountId]
           ,[ClientAccountStatusId]
           ,[CurrentBalance]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{9EEE3858-22C9-4A74-A238-65FCDA459BA9}'
           ,'TUSRA USD client account 01'
           ,'USD'
           ,'TUSRA'
           ,'{D6ECCB72-4DCF-4A2C-B224-9263C3DC6D29}'
           ,'NEW'
           ,1000
           ,'20170208 12:12'
           ,'20170208 12:12'
           ,''
           ,'')
INSERT INTO [ClientAccounts]
           ([Id]
           ,[Name]
           ,[CurrencyId]
           ,[ClientId]
           ,[BankAccountId]
           ,[ClientAccountStatusId]
           ,[CurrentBalance]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{35558256-A9C5-478D-A225-CF8F407C4160}'
           ,'TUSRB EUR client account 01'
           ,'EUR'
           ,'TUSRB'
           ,'{0D3476B3-9302-49F4-89E7-47109070D6D8}'
           ,'NEW'
           ,2000
           ,'20170209 12:12'
           ,'20170209 12:12'
           ,''
           ,'')

/* Cards */
INSERT INTO [Cards]
           ([Id]
           ,[ClientId]
           ,[CurrencyId]
           ,[CardNumber]
           ,[CardHolder]
           ,[ExpMonth]
           ,[ExpYear]
           ,[Limit]
           ,[Cvc]
           ,[Pin]
           ,[Vendor]
		   ,[IsInactive]
           ,[MainCardId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{6DB5ACC7-8CA5-4C9F-AA21-3B981C4BF73B}'
           ,'TUSRA'
           ,'USD'
           ,'1111-1111-1111-1111-1111'
           ,'Mr. Test User A'
           ,'02'
           ,'2019'
           ,50500
           ,'555'
           ,'1111'
           ,'NasterCard'
		   ,0
           ,null
           ,'20170209 12:12'
           ,'20170209 12:12'
           ,''
           ,'')
INSERT INTO [Cards]
           ([Id]
           ,[ClientId]
           ,[CurrencyId]
           ,[CardNumber]
           ,[CardHolder]
           ,[ExpMonth]
           ,[ExpYear]
           ,[Limit]
           ,[Cvc]
           ,[Pin]
           ,[Vendor]
		   ,[IsInactive]
           ,[MainCardId]
           ,[CreatedAt]
           ,[UpdatedAt]
           ,[CreatedBy]
           ,[UpdatedBy])
     VALUES
           ('{326100DF-813F-46A3-BCF9-BE1EBE56C44D}'
           ,'TUSRB'
           ,'EUR'
           ,'2222-1111-1111-1111-2222'
           ,'Mr. Test User B'
           ,'03'
           ,'2018'
           ,10500
           ,'666'
           ,'7777'
           ,'VISA'
		   ,0
           ,null
           ,'20170209 12:12'
           ,'20170209 12:12'
           ,''
           ,'')
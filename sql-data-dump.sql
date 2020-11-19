SET IDENTITY_INSERT [dbo].[Models] ON
INSERT INTO [dbo].[Models] ([Id], [Name]) VALUES (1, N'Fiersta')
INSERT INTO [dbo].[Models] ([Id], [Name]) VALUES (2, N'Model 3')
INSERT INTO [dbo].[Models] ([Id], [Name]) VALUES (3, N'Aygo')
SET IDENTITY_INSERT [dbo].[Models] OFF


SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([Id], [Name], [ModelId]) VALUES (1, N'Tesla', 1)
INSERT INTO [dbo].[Cars] ([Id], [Name], [ModelId]) VALUES (2, N'Ford', 2)
INSERT INTO [dbo].[Cars] ([Id], [Name], [ModelId]) VALUES (3, N'Toyota', 3)
SET IDENTITY_INSERT [dbo].[Cars] OFF


SET IDENTITY_INSERT [dbo].[Owners] ON
INSERT INTO [dbo].[Owners] ([Id], [Name]) VALUES (1, N'Albert')
INSERT INTO [dbo].[Owners] ([Id], [Name]) VALUES (2, N'Benny')
INSERT INTO [dbo].[Owners] ([Id], [Name]) VALUES (3, N'Carl')
SET IDENTITY_INSERT [dbo].[Owners] OFF


INSERT INTO [dbo].[CarOwners] ([CarId], [OwnerId]) VALUES (1, 1)
INSERT INTO [dbo].[CarOwners] ([CarId], [OwnerId]) VALUES (2, 1)
INSERT INTO [dbo].[CarOwners] ([CarId], [OwnerId]) VALUES (1, 3)



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCarCollection](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[CarMkModel] [varchar](50) NOT NULL,
	[Engine] [varchar](50) NOT NULL,
	[BodyType] [varchar](50) NOT NULL,
	[Transmission] [varchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[Value] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblCarCollection] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

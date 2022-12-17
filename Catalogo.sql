CREATE DATABASE Catalogo

 IF OBJECT_ID('[dbo].[Imagenes]') IS NOT NULL  DROP TABLE [dbo].[Imagenes]  GO 
 CREATE TABLE [dbo].[Imagenes] (  
    [Id_Imagen]  INT              IDENTITY(1,1)          NOT NULL, 
    [Nombre]     VARCHAR(100)                                NULL, 
    [Imagen]     VARCHAR(max)                                NULL, 
    [Fuente]     VARCHAR(max)                                NULL, 
    CONSTRAINT   [PK__Imagenes__B87925F6ED2E8E6B]  
    PRIMARY KEY CLUSTERED    ([Id_Imagen] asc) )  


IF OBJECT_ID('[dbo].[sp_Obtener_Imagenes]') IS NOT NULL  DROP  PROCEDURE [dbo].[sp_Obtener_Imagenes]  GO 
CREATE PROCEDURE sp_Obtener_ImagenesAS 
AS BEGIN
SELECT * FROM Imagenes
END
GO


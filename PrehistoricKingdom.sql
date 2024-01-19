Create table Especie(
	IdEspecie		int Identity(1,1) Not null,
	Nombre			varchar(50),
	Significado		varchar(75),
	Dieta			varchar(50),
	Peso			varchar(50),
	Periodo			varchar(50),
	Hallazgo		varchar(75),
	Dimensiones		varchar(50),
	Descripcion		varchar(250),
	Tiempo			varchar(100),
	Imagen			varchar(250),
	constraint pk_Especie Primary key(IdEspecie)
);

Create Procedure sp_Listar
As
Begin
    Select * From Especie 
End
go

Create Procedure sp_Obtener(
    @IdEspecie    int
)
AS
Begin
    Select * From Especie Where IdEspecie = @IdEspecie
End
go

Create Procedure sp_Registrar(
    @Nombre			varchar(50),
	@Significado	varchar(75),
	@Dieta			varchar(50),
	@Peso			varchar(50),
	@Periodo		varchar(50),
	@Hallazgo		varchar(75),
	@Dimensiones	varchar(50),
	@Descripcion	varchar(250),
	@Tiempo			varchar(100),
	@Imagen			varchar(250)
)
As
Begin
    Insert Into Especie(Nombre,Significado,Dieta,Peso,Periodo,Hallazgo,Dimensiones,Descripcion,Tiempo,Imagen) 
    Values(@Nombre,@Significado,@Dieta,@Peso,@Periodo,@Hallazgo,@Dimensiones,@Descripcion,@Tiempo,@Imagen)
End
go

Create Procedure sp_Editar(
	@IdEspecie        int,
    @Nombre			varchar(50),
	@Significado	varchar(75),
	@Dieta			varchar(50),
	@Peso			varchar(50),
	@Periodo		varchar(50),
	@Hallazgo		varchar(75),
	@Dimensiones	varchar(50),
	@Descripcion	varchar(250),
	@Tiempo			varchar(100),
	@Imagen			varchar(250)
)
As
Begin
	Update Especie Set Nombre = @Nombre, Significado = @Significado, Dieta = @Dieta, Peso = @Peso, Periodo = @Periodo, 
	Hallazgo = @Hallazgo, Dimensiones = @Dimensiones, Descripcion = @Descripcion, Tiempo = @Tiempo, Imagen = @Imagen
	Where IdEspecie = @IdEspecie
End
go

Create Procedure sp_Eliminar(
    @IdEspecie    int
)
AS
Begin
    Delete From Especie Where IdEspecie = @IdEspecie
End
go

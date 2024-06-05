using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciliador.Datos.Migrations
{
    /// <inheritdoc />
    public partial class ModeloEntidadRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogoConversion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConjuntoConversion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoConversion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquivalenciaConversion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConjuntoRelacionado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorRelacionado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoConversion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoNombre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoNombre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversionCentroCosto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoConversion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentroCostoConversion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BancoConversion = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionCentroCosto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdModuloPadre = table.Column<int>(type: "int", nullable: true),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modulo_Modulo_IdModuloPadre",
                        column: x => x.IdModuloPadre,
                        principalTable: "Modulo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCatalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCatalogo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoConciliacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConciliacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoFuente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoFuente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "moduloRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModulo = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moduloRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_moduloRoles_Modulo_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moduloRoles_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoGeneral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    IdTipoCatalogo = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoGeneral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogoGeneral_TipoCatalogo_IdTipoCatalogo",
                        column: x => x.IdTipoCatalogo,
                        principalTable: "TipoCatalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plantilla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePlantilla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InicioDetalles = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    IdTipoConciliacion = table.Column<int>(type: "int", nullable: false),
                    IdTipoFuente = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantilla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantilla_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plantilla_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plantilla_TipoConciliacion_IdTipoConciliacion",
                        column: x => x.IdTipoConciliacion,
                        principalTable: "TipoConciliacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plantilla_TipoFuente_IdTipoFuente",
                        column: x => x.IdTipoFuente,
                        principalTable: "TipoFuente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CabeceraPlantilla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    IdPlantilla = table.Column<int>(type: "int", nullable: false),
                    IdCatalogoGeneral = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabeceraPlantilla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CabeceraPlantilla_CatalogoGeneral_IdCatalogoGeneral",
                        column: x => x.IdCatalogoGeneral,
                        principalTable: "CatalogoGeneral",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CabeceraPlantilla_Plantilla_IdPlantilla",
                        column: x => x.IdPlantilla,
                        principalTable: "Plantilla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColumnasExcel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreColumna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    IdPlantilla = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColumnasExcel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColumnasExcel_Plantilla_IdPlantilla",
                        column: x => x.IdPlantilla,
                        principalTable: "Plantilla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesPlantilla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCampo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Columna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsCatalogo = table.Column<bool>(type: "bit", nullable: false),
                    NombreCatalogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorCatalogo = table.Column<int>(type: "int", nullable: true),
                    EsObligatorio = table.Column<bool>(type: "bit", nullable: false),
                    TipoOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPlantilla = table.Column<int>(type: "int", nullable: false),
                    IdCatalogoGeneral = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPlantilla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesPlantilla_CatalogoGeneral_IdCatalogoGeneral",
                        column: x => x.IdCatalogoGeneral,
                        principalTable: "CatalogoGeneral",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesPlantilla_Plantilla_IdPlantilla",
                        column: x => x.IdPlantilla,
                        principalTable: "Plantilla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroCabeceraPlantilla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoReferencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentroCostos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPlantilla = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroCabeceraPlantilla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroCabeceraPlantilla_Plantilla_IdPlantilla",
                        column: x => x.IdPlantilla,
                        principalTable: "Plantilla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroDetallePlantilla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorCampo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRegistroCabeceraPlantilla = table.Column<int>(type: "int", nullable: false),
                    IdCabeceraPlantilla = table.Column<int>(type: "int", nullable: false),
                    IdDetallePlantilla = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRegistro = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroDetallePlantilla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroDetallePlantilla_CabeceraPlantilla_IdCabeceraPlantilla",
                        column: x => x.IdCabeceraPlantilla,
                        principalTable: "CabeceraPlantilla",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegistroDetallePlantilla_DetallesPlantilla_IdDetallePlantilla",
                        column: x => x.IdDetallePlantilla,
                        principalTable: "DetallesPlantilla",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegistroDetallePlantilla_RegistroCabeceraPlantilla_IdRegistroCabeceraPlantilla",
                        column: x => x.IdRegistroCabeceraPlantilla,
                        principalTable: "RegistroCabeceraPlantilla",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraPlantilla_IdCatalogoGeneral",
                table: "CabeceraPlantilla",
                column: "IdCatalogoGeneral");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraPlantilla_IdPlantilla",
                table: "CabeceraPlantilla",
                column: "IdPlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogoGeneral_IdTipoCatalogo",
                table: "CatalogoGeneral",
                column: "IdTipoCatalogo");

            migrationBuilder.CreateIndex(
                name: "IX_ColumnasExcel_IdPlantilla",
                table: "ColumnasExcel",
                column: "IdPlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPlantilla_IdCatalogoGeneral",
                table: "DetallesPlantilla",
                column: "IdCatalogoGeneral");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPlantilla_IdPlantilla",
                table: "DetallesPlantilla",
                column: "IdPlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_IdModuloPadre",
                table: "Modulo",
                column: "IdModuloPadre");

            migrationBuilder.CreateIndex(
                name: "IX_moduloRoles_IdModulo",
                table: "moduloRoles",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_moduloRoles_IdRol",
                table: "moduloRoles",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Plantilla_IdEmpresa",
                table: "Plantilla",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Plantilla_IdRol",
                table: "Plantilla",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Plantilla_IdTipoConciliacion",
                table: "Plantilla",
                column: "IdTipoConciliacion");

            migrationBuilder.CreateIndex(
                name: "IX_Plantilla_IdTipoFuente",
                table: "Plantilla",
                column: "IdTipoFuente");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroCabeceraPlantilla_IdPlantilla",
                table: "RegistroCabeceraPlantilla",
                column: "IdPlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDetallePlantilla_IdCabeceraPlantilla",
                table: "RegistroDetallePlantilla",
                column: "IdCabeceraPlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDetallePlantilla_IdDetallePlantilla",
                table: "RegistroDetallePlantilla",
                column: "IdDetallePlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDetallePlantilla_IdRegistroCabeceraPlantilla",
                table: "RegistroDetallePlantilla",
                column: "IdRegistroCabeceraPlantilla");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                table: "Usuario",
                column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogoConversion");

            migrationBuilder.DropTable(
                name: "CatalogoNombre");

            migrationBuilder.DropTable(
                name: "ColumnasExcel");

            migrationBuilder.DropTable(
                name: "ConversionCentroCosto");

            migrationBuilder.DropTable(
                name: "moduloRoles");

            migrationBuilder.DropTable(
                name: "RegistroDetallePlantilla");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "CabeceraPlantilla");

            migrationBuilder.DropTable(
                name: "DetallesPlantilla");

            migrationBuilder.DropTable(
                name: "RegistroCabeceraPlantilla");

            migrationBuilder.DropTable(
                name: "CatalogoGeneral");

            migrationBuilder.DropTable(
                name: "Plantilla");

            migrationBuilder.DropTable(
                name: "TipoCatalogo");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TipoConciliacion");

            migrationBuilder.DropTable(
                name: "TipoFuente");
        }
    }
}

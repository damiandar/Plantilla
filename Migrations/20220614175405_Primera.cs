using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccesoriosArgentinos.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depositos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosProduccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosProduccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inyectoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inyectoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepositoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepositoId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matrices_Depositos_DepositoId1",
                        column: x => x.DepositoId1,
                        principalTable: "Depositos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesProduccionCabeceras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InyectoraId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesProduccionCabeceras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenesProduccionCabeceras_Inyectoras_InyectoraId",
                        column: x => x.InyectoraId,
                        principalTable: "Inyectoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Piezas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaId = table.Column<int>(type: "int", nullable: true),
                    InyectoraId = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoFabricacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatrizId = table.Column<int>(type: "int", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Bocas = table.Column<int>(type: "int", nullable: false),
                    TiempoDeInyeccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresionInyeccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VelocidadInyeccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curado = table.Column<int>(type: "int", nullable: false),
                    Carga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calefaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoyoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicionApertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProduccionPorHora = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piezas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piezas_Inyectoras_InyectoraId",
                        column: x => x.InyectoraId,
                        principalTable: "Inyectoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Piezas_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Piezas_Materiales_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materiales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Piezas_Matrices_MatrizId",
                        column: x => x.MatrizId,
                        principalTable: "Matrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialPiezas",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    PiezaId = table.Column<int>(type: "int", nullable: false),
                    Proporcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialPiezas", x => new { x.PiezaId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_MaterialPiezas_Materiales_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materiales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialPiezas_Piezas_PiezaId",
                        column: x => x.PiezaId,
                        principalTable: "Piezas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesProduccionDetalles",
                columns: table => new
                {
                    PiezaId = table.Column<int>(type: "int", nullable: false),
                    OrdenProduccionCabeceraId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    MatrizId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true),
                    OperarioId = table.Column<int>(type: "int", nullable: true),
                    ImpactosVacios = table.Column<int>(type: "int", nullable: false),
                    Ajuste = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesProduccionDetalles", x => new { x.PiezaId, x.OrdenProduccionCabeceraId });
                    table.ForeignKey(
                        name: "FK_OrdenesProduccionDetalles_EstadosProduccion_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadosProduccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesProduccionDetalles_Matrices_MatrizId",
                        column: x => x.MatrizId,
                        principalTable: "Matrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesProduccionDetalles_Operarios_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "Operarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesProduccionDetalles_OrdenesProduccionCabeceras_OrdenProduccionCabeceraId",
                        column: x => x.OrdenProduccionCabeceraId,
                        principalTable: "OrdenesProduccionCabeceras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenesProduccionDetalles_Piezas_PiezaId",
                        column: x => x.PiezaId,
                        principalTable: "Piezas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPiezas_MaterialId",
                table: "MaterialPiezas",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Matrices_DepositoId1",
                table: "Matrices",
                column: "DepositoId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesProduccionCabeceras_InyectoraId",
                table: "OrdenesProduccionCabeceras",
                column: "InyectoraId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesProduccionDetalles_EstadoId",
                table: "OrdenesProduccionDetalles",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesProduccionDetalles_MatrizId",
                table: "OrdenesProduccionDetalles",
                column: "MatrizId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesProduccionDetalles_OperarioId",
                table: "OrdenesProduccionDetalles",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesProduccionDetalles_OrdenProduccionCabeceraId",
                table: "OrdenesProduccionDetalles",
                column: "OrdenProduccionCabeceraId");

            migrationBuilder.CreateIndex(
                name: "IX_Piezas_InyectoraId",
                table: "Piezas",
                column: "InyectoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Piezas_MarcaId",
                table: "Piezas",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Piezas_MaterialId",
                table: "Piezas",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Piezas_MatrizId",
                table: "Piezas",
                column: "MatrizId");

            migrationBuilder.Sql("insert into Marcas (descripcion) values('Fiat')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Ford')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Peugeot')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Renault')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Citroen')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Dacia')");
            migrationBuilder.Sql("insert into marcas values('VW')");

            migrationBuilder.Sql("insert into materiales (DESCRIPCION,CODIGO) values('PP C/30% FIBRA DE VIDRIO','PP 30%FV NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/40% FIBRA DE VIDRIO','PP 40%FV NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/CAUCHO XT-428 X BOLSA 25KGS','PP CAUCHO NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP SIN CARGA SD6200','PP G-11 NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP NATURAL P/DEPOSITOS BOLSON X750KGS','PP GE 1200')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP/TD 10 NATURAL REC','PP/TD 10 NATURAL REC')");
            migrationBuilder.Sql("insert into materiales (DESCRIPCION,CODIGO) values('PP/TD 20','PP/TD 20') ");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/20%TALCO X BOLSA 25KGS','PP/TD20 NAT. VIRGEN')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/20% TALCO X BOLSA 25KGS','PP/TD20 NEGRO VIRGEN')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/20%TALCO RECUP.X BOLSA 25KGS','PP/TD20 RG NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/40%TALCO RECUP.X BOLSA 25KGS','PP/TD40 CM NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/5%TALCO MAS ENGANGE STS X BOLSA 20KGS','PP/TD5 ENGANGE NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('NYLON 6 C/15%FVNEG','NYLON 6 C/15%FVNEG')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('NYLON 6 NATURAL','NYLON 6 NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('NYLON 6 NEGRO','NYLON 6 NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('NYLON 6.6 NATURAL','NYLON 6.6 NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('NYLON 6.6 NEGRO','NYLON 6.6 NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('NYLON6.6C/25%-FV NEG','NYLON6.625%-FV NEG')");


            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('ACETAL NATURAL','ACETAL NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PBT 30% FV NATURAL','PBT 30% FV NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PBT 30% FVNEGRO','PBT 30% FVNEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('POLIETILENO G-2 NATURAL','POLIETILENO G-2 NATU')");

            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PVC NATURAL 90SHA 6XT','PVC CRISTAL NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PVC NATURAL 65 SHA','PVC NATURAL')");


            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('TPE NATURAL 25X20KG','TPE NATURAL 25X20KG')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('TPENATURAL 55X20KG','TPENATURAL 25X20KG')");

            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('ABS Starex','ABS Starex')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('ABS Negro','ABS Negro')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('ABS Cromas','ABS Cromas')");
            migrationBuilder.Sql("insert into Materiales (descripcion,codigo) values('ABS Recuperado','ABS Recuperado')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PPCMPPT','PPCMPPT')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP RECUPERADO','PP RECUPERADO')");


            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Anillo goma engranaje plastico','55611')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Eje engranaje cuerpo mariposa Ex38','CH133062EJE')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ruleman alt. SKF 6203 -2RSH/C3LHT23','SKF6203C3L')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ruleman SKF 6204-2RSH','6204 -2RSH')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ruleman SKF 6005 2-Z','SKF6005-2Z')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ruleman bomba de agua grande','1234060I')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ruleman p/armar tensor correa C10924335A','CH10924335A')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Grampa moldura guardabarro p/armar','CH8370354-T')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Tuerca plastica moldura guarda. p/amar','C8370354A-')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Buje moleteado Ex39','VOL5Z0805757')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Tornillo corto para panel Classic 2010','CH853447 5CC')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Tornillo largo para panel Classic 2010','CH853447 5CL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Regaton para armar C8534475CE','REGATON')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Moldura cromada izq.p/rejilla','5Z0853361MOLD')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Moldura cromada derecha.p/rejilla','5Z0853362MOLD')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Moldura cromada p/rejilla central','5Z0853671MOLD')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Tapon de aluminio purga colector 1336G10A','1226000N')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Tornillo tapizado puerta negro','6908161N')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Buje tapa distrib. 10(diam.ext.x3,5x8,25','FIATEX37')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Buje tapa distrib. 9x3,5x7','FIATEX36')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Buje tapa distrib. 6x1 cuadrado','FIATEX34')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Buje tapa distrib. 9x5x7','FIATEX35')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Oring para tornillo purgador 1917210A','PG1917210A')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ojal para armadura delant.P.206','7104CWOJ')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Inserto para armadura delant.P.206','7104CWIN')");



            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('VALLEJOS')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('PLANTA CASEROS')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('TUCUMAN')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('TUCUMAN NUEVO')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('FISCHETTI')");


            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('324' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('253' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('55'  ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('131' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('185' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('196' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('191' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('109' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('261' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('155' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('291' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('293' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('344' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('456' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('256' ,1,'')");
            migrationBuilder.Sql("insert into matrices (descripcion,depositoid,estado) values('254' ,1,'')");
            migrationBuilder.Sql("insert into Inyectoras values('150 ton') ");
            migrationBuilder.Sql("insert into Inyectoras values('88 ton')");
            migrationBuilder.Sql("insert into Inyectoras values('500 ton')");
            migrationBuilder.Sql("insert into Inyectoras values('350 ton')");
            migrationBuilder.Sql("insert into Inyectoras values('250 ton')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialPiezas");

            migrationBuilder.DropTable(
                name: "OrdenesProduccionDetalles");

            migrationBuilder.DropTable(
                name: "EstadosProduccion");

            migrationBuilder.DropTable(
                name: "Operarios");

            migrationBuilder.DropTable(
                name: "OrdenesProduccionCabeceras");

            migrationBuilder.DropTable(
                name: "Piezas");

            migrationBuilder.DropTable(
                name: "Inyectoras");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Matrices");

            migrationBuilder.DropTable(
                name: "Depositos");
        }
    }
}

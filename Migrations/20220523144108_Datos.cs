using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccesoriosArgentinos.Migrations
{
    public partial class Datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                    
                    
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Fiat')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Ford')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Peugeot')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Renault')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Citroen')");
            migrationBuilder.Sql("insert into Marcas (descripcion) values('Dacia')");

            migrationBuilder.Sql("insert into materiales (DESCRIPCION,CODIGO) values('PP C/30% FIBRA DE VIDRIO','PP 30%FV NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/40% FIBRA DE VIDRIO','PP 40%FV NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/CAUCHO XT-428 X BOLSA 25KGS','PP CAUCHO NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP SIN CARGA SD6200','PP G-11 NATURAL')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP NATURAL P/DEPOSITOS BOLSON X750KGS','PP GE 1200')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP/TD 10 NATURAL REC','PP/TD 10 NATURAL REC')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/20%TALCO X BOLSA 25KGS','PP/TD20 NAT. VIRGEN')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/20% TALCO X BOLSA 25KGS','PP/TD20 NEGRO VIRGEN')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/20%TALCO RECUP.X BOLSA 25KGS','PP/TD20 RG NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/40%TALCO RECUP.X BOLSA 25KGS','PP/TD40 CM NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('PP C/5%TALCO MAS ENGANGE STS X BOLSA 20KGS','PP/TD5 ENGANGE NEGRO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('ABS Negro')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('ABS Cromas')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('PPG-11') ");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('PPCMPPT + PPG11')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('PP RECUPERADO')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('NYLON 6.6 c/25% FV')");


            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Anillo goma engranaje plastico')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Eje engranaje cuerpo mariposa Ex38')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Ruleman alt. SKF 6203 -2RSH/C3LHT23')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Ruleman SKF 6204-2RSH')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Ruleman SKF 6005 2-Z')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Ruleman bomba de agua grande')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('Ruleman p/armar tensor correa C10924335A')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('grampa moldura guardabarro p/armar')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('tuerca plastica moldura guarda. p/amar')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('buje moleteado Ex39')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('tornillo corto para panel Classic 2010')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('tornillo largo para panel Classic 2010')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('regaton para armar C8534475CE')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('moldura cromada izq.p/rejilla')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('moldura cromada derecha.p/rejilla')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('moldura cromada p/rejilla central')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('tapon de aluminio purga colector 1336G10A')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('tornillo tapizado puerta negro')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('buje tapa distrib. 10(diam.ext.x3,5x8,25')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('buje tapa distrib. 9x3,5x7')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('buje tapa distrib. 6x1 cuadrado')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('buje tapa distrib. 9x5x7')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('oring para tornillo purgador 1917210A')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('ojal para armadura delant.P.206')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('inserto para armadura delant.P.206')");

            

            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('VALLEJOS')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('PLANTA CASEROS')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('TUCUMAN')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('TUCUMAN NUEVO')");
            migrationBuilder.Sql("insert into depositos (DESCRIPCION) values('FISCHETTI')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
        }
    }
}

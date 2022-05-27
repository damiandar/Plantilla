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

            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('ABS Negro')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('ABS Cromas')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('PPCMPPT')");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION) values('PP RECUPERADO')"); 


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
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Ojal para armadura delant.P.206',7104CWOJ)");
            migrationBuilder.Sql("insert into Materiales (DESCRIPCION,CODIGO) values('Inserto para armadura delant.P.206',7104CWIN)");

            

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

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
        }
    }
}

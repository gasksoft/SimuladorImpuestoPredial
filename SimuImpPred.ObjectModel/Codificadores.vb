Public Module Codificadores
    Public TipoDocumentoIdentidad As New Dictionary(Of Integer, String) From {
        {0, "Ninguno"}, {1, "DNI"}, {4, "Carn� Extranjeria"}, {6, "RUC"}, {8, "Sucesion Indivisa"}}

    Public CondicionEspecialContribuyente As New Dictionary(Of Integer, String) From {
        {1, "NINGUNA"}, {2, "GOBIERNO CENTRAL"}, {3, "GOBIERNO REGIONAL"}, {4, "GOBIERNO LOCAL"},
        {5, "GOBIERNO EXTRANJERO"}, {6, "UNIVERSIDADES"}, {7, "CENTRO EDUCATIVO ESTATAL"},
        {8, "CENTRO EDUCATIVO NO ESTATAL"}, {9, "BENEFICENCIA"}, {10, "HOSPITAL"}, {11, "ENTIDAD RELIGIOSA"},
        {12, "PENSIONISTA"}, {13, "COMPA��A DE BOMBEROS"}, {14, "COMUNIDAD CAMPESINA/NATIVA"},
        {15, "ORGANISMO INTERNACIONAL"}, {16, "ORGANIZACI�N POL�TICA"}, {17, "ORGANIZACI�N SINDICAL"},
        {18, "ORGANIZACI�N DE PERSONAS CON DISCAPACIDAD"}, {19, "ESTA MUNICIPALIDAD"},
        {20, "FUERZAS ARMADAS Y POLICIALES"}, {21, "EMPRESA EN LIQUIDACI�N"}}

    Public CondicionPropietario As New Dictionary(Of Integer, String) From {
        {1, "PROPIETARIO UNICO"}, {2, "SUCESION INDIVISA"}, {3, "POSEEDOR TENEDOR"}, {4, "SOCIEDAD CONYUGAL"},
        {5, "CONDOMINIO - COPROPIETARIO"}, {6, "LITIGIO"}, {7, "R�GIMEN DE CONVIVENCIA"}}

    Public TipoPredio As New Dictionary(Of Integer, String) From {
        {1, "PREDIO INDEPENDIENTE"}, {2, "DEPARTAMENTO U OFICINA EN EDIFICIO"}, {3, "PREDIO EN QUINTA/CONDOMINIO"},
        {4, "PREDIO EN CALLEJON,SOLAR,CORRALON"}, {5, "PREDIO EN MERCADO"}, {6, "PREDIO EN GALERIA"},
        {7, "TERRENO SIN CONSTRUIR"}}

    Public EstadoConstruccion As New Dictionary(Of Integer, String) From {
        {1, "TERRENO SIN CONSTRUIR"}, {2, "EN CONSTRUCCION"}, {3, "TERMINADO"}, {4, "EN RUINAS"}}

    Public ClasificacionPredio As New Dictionary(Of Integer, String) From {
        {1, "Casa habitaci�n, departamentos para viviendas incluidas las ubicadas en edificios"},
        {2, "Tiendas, dep�sitos, centros de recreaci�n o esparcimiento, clubes sociales o instituciones"},
        {3, "Edificios � oficinas"},
        {4, "Edificaciones de salud, cines, industrias, edificaciones de uso educativo, talleres"}}

    Public TipoContrato As New Dictionary(Of Integer, String) From {
        {1, "Compraventa T�pica (Simple)"}, {2, "Compraventa de Bien Futuro"},
        {3, "Compraventa T�pica con Reserva de Propiedad"},
        {4, "Compraventa de Bien Futuro con Reserva de Propiedad"},
        {5, "Anticipo de Leg�tima"}, {6, "Sucesi�n Intestada"}, {7, "Sucesi�n Testamentaria"},
        {8, "Divisi�n y Partici�n de Masa Hereditaria"}, {9, "Divisi�n y Partici�n de Gananciales"},
        {10, "Divisi�n y Partici�n de Cond�minos Originarios"}, {11, "Adjudicaci�n por Remate Judicial"},
        {12, "Resoluci�n de Contrato de Transferencia antes de Cancelar el Precio"},
        {13, "Resoluci�n de Contrato de Transferencia con el Precio cancelado"},
        {14, "Donaci�n"}, {15, "Daci�n en Pago"}, {16, "Permuta Simple"},
        {17, "Permuta con Reserva de Propiedad"}, {18, "Ejecuci�n de Pacto de Retroventa"},
        {19, "Cesi�n de Posici�n Contractual"}, {20, "Aporte de Capital"},
        {21, "Transferencia por Reorganizaci�n de Empresas"},
        {22, "Opci�n Derivada del Contrato de Arrendamiento Financiero"},
        {23, "Adjudicaci�n por Disoluci�n de Sociedad"}, {24, "Expropiaci�n"}}

    Public UsoTerreno As New Dictionary(Of Integer, String) From {
        {1, "AGRICOLA"}, {2, "GANADERA"}, {3, "AVICOLA"}, {4, "FORESTAL"}, {5, "AGRO INDUSTRIAL"}, {6, "OTROS"}}

    Public TipoTerrenoRural As New Dictionary(Of Integer, String) From {
        {1, "HACIENDA"}, {2, "FUNDO"}, {3, "LOTE"}, {4, "PARCELA"}, {5, "CHACRA"}, {6, "ESTABLO"}, {7, "GRANJA"}}
    Public TipoPiso As New Dictionary(Of Integer, String) From {
        {1, "PISO"}, {2, "SOTANO"}, {3, "MEZANINE"}, {4, "AC PISO"}, {5, "AC SOTANO"}}
End Module
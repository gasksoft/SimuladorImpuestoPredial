Imports SimuImpPred.Data

Public Module Codificadores
    Public ReadOnly TipoDocumentoIdentidadDic As New Dictionary(Of Integer, String) From {
        {0, "Ninguno"}, {1, "DNI"}, {4, "Carné Extranjeria"}, {6, "RUC"}, {8, "Sucesion Indivisa"}}

    Public ReadOnly CondicionEspecialContribuyenteDic As New Dictionary(Of Integer, String) From {
        {1, "NINGUNA"}, {2, "GOBIERNO CENTRAL"}, {3, "GOBIERNO REGIONAL"}, {4, "GOBIERNO LOCAL"},
        {5, "GOBIERNO EXTRANJERO"}, {6, "UNIVERSIDADES"}, {7, "CENTRO EDUCATIVO ESTATAL"},
        {8, "CENTRO EDUCATIVO NO ESTATAL"}, {9, "BENEFICENCIA"}, {10, "HOSPITAL"}, {11, "ENTIDAD RELIGIOSA"},
        {12, "PENSIONISTA"}, {13, "COMPAÑÍA DE BOMBEROS"}, {14, "COMUNIDAD CAMPESINA/NATIVA"},
        {15, "ORGANISMO INTERNACIONAL"}, {16, "ORGANIZACIÓN POLÍTICA"}, {17, "ORGANIZACIÓN SINDICAL"},
        {18, "ORGANIZACIÓN DE PERSONAS CON DISCAPACIDAD"}, {19, "ESTA MUNICIPALIDAD"},
        {20, "FUERZAS ARMADAS Y POLICIALES"}, {21, "EMPRESA EN LIQUIDACIÓN"}}

    Public CondicionPropietarioDic As New Dictionary(Of Integer, String) From {
        {1, "PROPIETARIO UNICO"}, {2, "SUCESION INDIVISA"}, {3, "POSEEDOR TENEDOR"}, {4, "SOCIEDAD CONYUGAL"},
        {5, "CONDOMINIO - COPROPIETARIO"}, {6, "LITIGIO"}, {7, "RÉGIMEN DE CONVIVENCIA"}}

    Public TipoPredioDic As New Dictionary(Of Integer, String) From {
        {1, "PREDIO INDEPENDIENTE"}, {2, "DEPARTAMENTO U OFICINA EN EDIFICIO"}, {3, "PREDIO EN QUINTA/CONDOMINIO"},
        {4, "PREDIO EN CALLEJON,SOLAR,CORRALON"}, {5, "PREDIO EN MERCADO"}, {6, "PREDIO EN GALERIA"},
        {7, "TERRENO SIN CONSTRUIR"}}

    Public EstadoConstruccionDic As New Dictionary(Of Integer, String) From {
        {1, "TERRENO SIN CONSTRUIR"}, {2, "EN CONSTRUCCION"}, {3, "TERMINADO"}, {4, "EN RUINAS"}}

    Public ClasificacionPredioDic As New Dictionary(Of Integer, String) From {
        {1, "Casa habitación, departamentos para viviendas incluidas las ubicadas en edificios"},
        {2, "Tiendas, depósitos, centros de recreación o esparcimiento, clubes sociales o instituciones"},
        {3, "Edificios – oficinas"},
        {4, "Edificaciones de salud, cines, industrias, edificaciones de uso educativo, talleres"}}

    Public TipoContratoDic As New Dictionary(Of Integer, String) From {
        {1, "Compraventa Típica (Simple)"}, {2, "Compraventa de Bien Futuro"},
        {3, "Compraventa Típica con Reserva de Propiedad"},
        {4, "Compraventa de Bien Futuro con Reserva de Propiedad"},
        {5, "Anticipo de Legítima"}, {6, "Sucesión Intestada"}, {7, "Sucesión Testamentaria"},
        {8, "División y Partición de Masa Hereditaria"}, {9, "División y Partición de Gananciales"},
        {10, "División y Partición de Condóminos Originarios"}, {11, "Adjudicación por Remate Judicial"},
        {12, "Resolución de Contrato de Transferencia antes de Cancelar el Precio"},
        {13, "Resolución de Contrato de Transferencia con el Precio cancelado"},
        {14, "Donación"}, {15, "Dación en Pago"}, {16, "Permuta Simple"},
        {17, "Permuta con Reserva de Propiedad"}, {18, "Ejecución de Pacto de Retroventa"},
        {19, "Cesión de Posición Contractual"}, {20, "Aporte de Capital"},
        {21, "Transferencia por Reorganización de Empresas"},
        {22, "Opción Derivada del Contrato de Arrendamiento Financiero"},
        {23, "Adjudicación por Disolución de Sociedad"}, {24, "Expropiación"}}

    Public UsoTerrenoDic As New Dictionary(Of Integer, String) From {
        {1, "AGRICOLA"}, {2, "GANADERA"}, {3, "AVICOLA"}, {4, "FORESTAL"}, {5, "AGRO INDUSTRIAL"}, {6, "OTROS"}}

    Public TipoTerrenoRuralDic As New Dictionary(Of Integer, String) From {
        {1, "HACIENDA"}, {2, "FUNDO"}, {3, "LOTE"}, {4, "PARCELA"}, {5, "CHACRA"}, {6, "ESTABLO"}, {7, "GRANJA"}}

    Public TipoPisoDic As New Dictionary(Of Integer, String) From {
        {1, "PISO"}, {2, "SOTANO"}, {3, "MEZANINE"}, {4, "AC PISO"}, {5, "AC SOTANO"}}

    Public ReadOnly TipoViaDic As New Dictionary(Of Integer, String) From {
        {1, "AVENIDA"}, {2, "CALLE"}, {3, "JIRON"}, {4, "PASAJE"}, {5, "ALAMEDA"}, {6, "CARRETERA"}, {7, "PROLONGACION"},
        {8, "PASEO"}, {9, "MALECON"}, {10, "CAMINO"}, {11, "PLAZA"}, {12, "PLAZUELA"}}

    Public ReadOnly TipoHabilitacionDic As New Dictionary(Of Integer, String) From {
        {1, "ASENTAMIENTO HUMANO"}, {2, "AGRUPACION"}, {3, "CONJUNTO HABITACIONAL"}, {4, "CONJUNTO RESIDENCIAL"},
        {5, "PUEBLO JOVEN"}, {6, "URBANIZACION"}, {7, "URBANIZACION POPULAR"}, {8, "CERCADO"}, {9, "HACIENDA"},
        {10, "ASOCIACION"}, {11, "COOPERATIVA"}, {12, "LOTIZACION"}, {13, "PARCELA"}, {14, "VALLE"}, {15, "CASERÍO"},
        {16, "UNIDAD VECINAL"}, {17, "COMUNIDAD"}, {18, "BARRIO"}, {19, "FUNDO"}, {20, "JUNTA DE COMPRADORES"},
        {21, "ASOCIACION DE VIVIENDA"}, {22, "COOPERATIVA DE VIVIENDA"}, {23, "SOCIEDAD"},
        {24, "ASOCIACION PRO VIVIENDA"},
        {25, "ZONA"}, {26, "CENTRO POBLADO"}, {27, "ANEXO"}, {28, "LUGAR"}, {29, "REGION"}, {99, "SIN HABILITACION"}}

    Public ReadOnly DepartamentosList As List(Of UDep) = ParameterProvider.GetDepartamentos()
End Module
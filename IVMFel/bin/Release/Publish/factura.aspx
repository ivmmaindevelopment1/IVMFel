<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="factura.aspx.cs" Inherits="IVMFel.factura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .txt {
              width: 100%;
              padding: 12px 20px;
              font-family: Calibri;
              margin: 8px 0;
              box-sizing: border-box;
              border: none;
              border: 2px solid gray;
              border-radius: 4px;
              font-size: 20px;
              /*border-bottom: 2px solid gray;*/
        }
        .txt:focus{
            /*border-bottom: 3px solid #555;*/
            border: 3px solid #555;
        }
        .btn{
            font-size: 20px;
            font-family: Calibri;
        }
        .lbl{
            font-size: 20px;
            font-family: Calibri;
            font-style: bold;
        }
        div{
            border: 3px solid #555;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div width="100%" runat="server" id="divGeneral">
                     
        </div>
    </form>
</body>
</html>

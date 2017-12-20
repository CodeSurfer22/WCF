<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="ViewGridPerson" runat="server">
            
                <asp:GridView ID="GridPerson" runat="server" AutoGenerateSelectButton="True" Caption="Line Managers"
                    OnSelectedIndexChanged="GridPerson_SelectedIndexChanged" DataKeyNames="PersonId"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                    GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="PersonId" HeaderText="ID" />
                        <asp:BoundField DataField="LastName" HeaderText=" Last Name" />
                        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                        <asp:BoundField DataField="BirthDate" HeaderText="Birth Date" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <br />
                <asp:Label ID="lblError" runat="server" Text="" Visible="false"></asp:Label>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"
                                OnClientClick="return confirmation();" />
                        </td>
                        <td>
                            <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" OnClick="btnAddEmployee_Click" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="ViewSavePerson" runat="server">
            <asp:Panel ID="Panel1" GroupingText="Line Manager Details" BorderStyle="Dotted" 
                    runat="server">
                            
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnSubmitPerson" runat="server" OnClick="btnSubmitPerson_Click" Text="Save" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                        </td>
                        <td style="width: 84px">
                            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                        </td>
                        <td style="width: 84px">
                            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="DOB"></asp:Label>
                        </td>
                        <td style="width: 84px">
                            <asp:Calendar ID="calDOB" runat="server" OnSelectionChanged="calDOB_SelectionChanged">
                            </asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td style="width: 84px">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                </asp:Panel>
            </asp:View>
            <asp:View ID="ViewSaveEmployee" runat="server">
            <asp:Panel ID="Panel2" GroupingText="Edit Employee Details" BorderStyle="Dotted" 
                    runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnBackEmployee" runat="server" Text="Back" 
                                onclick="btnBackEmployee_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnSaveEmployee" runat="server" Text="Save" 
                                onclick="btnSaveEmployee_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Employee Number"></asp:Label>
                        </td>
                        <td style="width: 84px">
                            <asp:TextBox ID="txtEmployeeNumber" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Employed Date"></asp:Label>
                        </td>
                        <td>
                            <asp:Calendar ID="calEmpDate" runat="server"></asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Terminated Date"></asp:Label>
                        </td>
                        <td style="width: 84px">
                            <asp:Calendar ID="calTermDate" runat="server"></asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td style="width: 84px">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                </asp:Panel>
            </asp:View>
        </asp:MultiView>
        <asp:GridView ID="GridEmployee" runat="server"
            Caption="Employees" AutoGenerateColumns="False"
            onselectedindexchanged="GridEmployee_SelectedIndexChanged" CellPadding="4" 
            ForeColor="#333333" DataKeyNames="EmployeeId" GridLines="None" 
            AutoGenerateSelectButton="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="Employee ID" />
                <asp:BoundField DataField="EmployeeNumber" HeaderText="Employee Number" />
                <asp:BoundField DataField="EmployedDate" HeaderText="Employed Date" />
                <asp:BoundField DataField="TerminatedDate" HeaderText="Terminated Date" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
                <asp:Label ID="lblErrorEmp" runat="server" Text="" Visible="false"></asp:Label>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnEditEmp" runat="server" Visible="false" Text="Edit" 
                        onclick="btnEditEmp_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>

</asp:Content>

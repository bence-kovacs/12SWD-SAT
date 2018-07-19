Option Strict On

Public Class EquipmentInventory

    Public Shared Function CreateDataSet() As DataSet
        'Creates a new dataset, 2 datatables and adds data to them
        Dim dsData As New DataSet("EquipmentInventoryList")

        'Create category datatable and add categories
        Using dt As New DataTable("Categories")
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("Description", GetType(String))

            dt.LoadDataRow(New Object() {1, "Audio"}, True)
            dt.LoadDataRow(New Object() {2, "Video"}, True)
            dt.LoadDataRow(New Object() {3, "Lighting"}, True)
            dt.LoadDataRow(New Object() {4, "Tripods & Mounts"}, True)
            dt.LoadDataRow(New Object() {5, "Miscellaneous"}, True)

            dsData.Tables.Add(dt)
        End Using

        'Create datatable for equipment and add equipment to it
        Using dt As New DataTable("Equipment")
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("IDParent", GetType(Integer))
            dt.Columns.Add("Description", GetType(String))


            dt.LoadDataRow(New Object() {2, 1, "NTG-3"}, True)
            dt.LoadDataRow(New Object() {3, 1, "VideoMIC Go"}, True)
            dt.LoadDataRow(New Object() {4, 1, "RadioMic"}, True)
            dt.LoadDataRow(New Object() {5, 1, "HandHeldMic"}, True)
            dt.LoadDataRow(New Object() {6, 1, "ZOOM H6"}, True)
            dt.LoadDataRow(New Object() {14, 2, "Panasonic GH5 Kit"}, True)
            dt.LoadDataRow(New Object() {15, 2, "Panasonic GH4 Kit"}, True)
            dt.LoadDataRow(New Object() {16, 2, "Canon XA20 Kit"}, True)
            dt.LoadDataRow(New Object() {20, 3, "LEDGO Light Panel Kit"}, True)
            dt.LoadDataRow(New Object() {21, 3, "Softbox Kit"}, True)
            dt.LoadDataRow(New Object() {22, 3, "Reflector/Difuser Kit"}, True)
            dt.LoadDataRow(New Object() {25, 4, "Heavy Duty Tripod"}, True)
            dt.LoadDataRow(New Object() {26, 4, "Video Tripod"}, True)
            dt.LoadDataRow(New Object() {27, 4, "CAME-TV 3 Axis Gimbal"}, True)
            dt.LoadDataRow(New Object() {28, 4, "Shoulder Mount"}, True)
            dt.LoadDataRow(New Object() {29, 4, "Gorillapod"}, True)
            dt.LoadDataRow(New Object() {30, 5, "SD Card (32gb)"}, True)
            dt.LoadDataRow(New Object() {31, 5, "SD Card (64gb)"}, True)
            dt.LoadDataRow(New Object() {32, 5, "Slate"}, True)
            dt.LoadDataRow(New Object() {33, 5, "Teleprompter"}, True)
            dt.LoadDataRow(New Object() {34, 5, "Atmosphere Spray"}, True)
            dt.LoadDataRow(New Object() {35, 5, "Green Screen"}, True)
            dt.LoadDataRow(New Object() {36, 5, "XLR Cable (5m)"}, True)
            dt.LoadDataRow(New Object() {37, 5, "Extension Lead"}, True)
            dt.LoadDataRow(New Object() {38, 5, "Power Board"}, True)
            dt.LoadDataRow(New Object() {30, 5, "AA Battery Charger"}, True)


            dsData.Tables.Add(dt)
        End Using
        Return dsData
    End Function
End Class

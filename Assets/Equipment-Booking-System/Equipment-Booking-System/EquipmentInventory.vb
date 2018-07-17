Option Strict On

Public Class EquipmentInventory

    Public Shared Function CreateDataSet() As DataSet
        'Creates a new dataset, 2 datatables and adds data to them
        Dim dsData As New DataSet("EquipmentInventoryList")

        Using dt As New DataTable("Categories")
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("Description", GetType(String))

            dt.LoadDataRow(New Object() {1, "Audio"}, True)
            dt.LoadDataRow(New Object() {2, "Video"}, True)
            dt.LoadDataRow(New Object() {3, "Miscellaneous"}, True)

            dsData.Tables.Add(dt)
        End Using

        Using dt As New DataTable("Equipment")
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("IDParent", GetType(Integer))
            'dt.Columns.Add("Code", GetType(String))
            dt.Columns.Add("Description", GetType(String))


            'dt.LoadDataRow(New Object() {1, 1, "AB", "Alberta", 3153700}, True)
            dt.LoadDataRow(New Object() {2, 1, "RODE NTG-3"}, True)
            dt.LoadDataRow(New Object() {3, 1, "VideoMIC Go"}, True)
            dt.LoadDataRow(New Object() {4, 1, "RadioMic"}, True)
            dt.LoadDataRow(New Object() {5, 1, "HandHeldMic"}, True)
            dt.LoadDataRow(New Object() {6, 1, "ZOOM H6"}, True)
            dt.LoadDataRow(New Object() {14, 2, "GH5"}, True)
            dt.LoadDataRow(New Object() {15, 2, "GH4"}, True)
            dt.LoadDataRow(New Object() {16, 2, "XA20"}, True)

            dsData.Tables.Add(dt)
        End Using

        Using dt As New DataTable("Description")
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("IDSelection", GetType(Integer))
            dt.Columns.Add("Description", GetType(String))

            dt.LoadDataRow(New Object() {1, 2, "The RODE NTG-3 is a omni-directional microphone specializing in gathering background audio. It can be mounted on a camera."}, True)
            dt.LoadDataRow(New Object() {2, 3, "The RODE VideoMIC GO is a shotgun mic"}, True)
            dt.LoadDataRow(New Object() {3, 14, "The Panasonic GH5 is a highly capable video DSLM Camera specialized in the capture of video"}, True)

        End Using

        Return dsData
    End Function
End Class

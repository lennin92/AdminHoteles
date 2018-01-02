@ModelType IEnumerable(Of AdminHoteles.Hotel)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombreHotel)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.direccionHotel)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.estrellasHotel)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombreHotel)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.direccionHotel)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.estrellasHotel)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.hotelId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.hotelId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.hotelId })
        </td>
    </tr>
Next

</table>

@ModelType IEnumerable(Of AdminHoteles.Habitacion)
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
            @Html.DisplayNameFor(Function(model) model.hotelId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tipoHabitacionId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombreHabitacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.descripcionHabitacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ubicacionHabitacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.precioBaseHabitacion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hotelId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tipoHabitacionId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombreHabitacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.descripcionHabitacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ubicacionHabitacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.precioBaseHabitacion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.habitacionId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.habitacionId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.habitacionId })
        </td>
    </tr>
Next

</table>

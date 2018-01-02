@ModelType IEnumerable(Of AdminHoteles.PrecioHabitacion)
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
            @Html.DisplayNameFor(Function(model) model.habitacionId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.precioSugerido)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.precioMinimo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.desde)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.hasta)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.habitacionId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.precioSugerido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.precioMinimo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.desde)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hasta)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.precioHabitacionId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.precioHabitacionId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.precioHabitacionId })
        </td>
    </tr>
Next

</table>

@ModelType IEnumerable(Of AdminHoteles.Cliente)
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
            @Html.DisplayNameFor(Function(model) model.nombresCliente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.apellidosCliente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.numeroIdentificacionCliente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tipoIdentificacionCliente)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombresCliente)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.apellidosCliente)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.numeroIdentificacionCliente)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tipoIdentificacionCliente)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.clienteId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.clienteId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.clienteId })
        </td>
    </tr>
Next

</table>

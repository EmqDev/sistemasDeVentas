Public Interface IGenericRepository(Of Entity As Class)
    Function GetAll() As IEnumerable(Of Entity)
    Function Add(entity As Entity) As Integer
    Function Edit(entity As Entity) As Integer
    Function Remove(id As Integer) As Integer

End Interface

using MediatR;


namespace AdventureWorks.Application.Features.Humanresources.Queries.Department
{
    public class GetDepartmentListQuery: IRequest<List<DepartmentVm>>
    {
        public GetDepartmentListQuery()
        {            
        }
    }
}

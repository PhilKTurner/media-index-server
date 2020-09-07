using GraphQL.Types;

namespace MediaIndexServer.WebApi.GraphQL
{
    public class MediaIndexSchema : Schema
    {
        public MediaIndexSchema(MediaIndexQuery query, MediaIndexMutation mutation)
        {
            Query = query;
            Mutation = mutation;
        }
    }
}
export interface MutationResponse {
  type: string;
  actionSucceeded: boolean;
  deletedId: string;
  entity: object;
}

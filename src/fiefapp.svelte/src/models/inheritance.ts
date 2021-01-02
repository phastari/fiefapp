interface IInheritance {
  id: string;
  type: InheritanceType | undefined;
  name: string;
  description: string;
}

export enum InheritanceType {
  HEREDITARY = 'HEREDITARY',
  NOT_HEREDITARY = 'NOT_HEREDITARY',
  PLEDGE = 'PLEDGE',
  LEASE = 'LEASE',
}

export class Inheritance implements IInheritance {
  id: string;
  type: InheritanceType | undefined;
  name: string;
  description: string;

  constructor(
    id?: string,
    type?: InheritanceType,
    name?: string,
    description?: string
  ) {
    this.id = id ? id : '';
    this.type = type ? type : undefined;
    this.name = name ? name : '';
    this.description = description ? description : '';
  }
}

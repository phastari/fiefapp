interface IInheritance {
  type: InheritanceType;
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
  constructor(
    public type: InheritanceType,
    public name: string,
    public description: string
  ) {}
}

export const emptyInheritance: Inheritance = {
  type: InheritanceType.HEREDITARY,
  name: '',
  description: '',
};

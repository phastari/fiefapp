import { Inheritance, InheritanceType } from '../inheritance';

interface IInheritanceAlternative {
  type: string;
  name: string;
  description: string;
}

export class InheritanceAlternative implements IInheritanceAlternative {
  constructor(
    public type: string,
    public name: string,
    public description: string
  ) {}

  public create(): Inheritance {
    return new Inheritance(
      InheritanceType[this.type as keyof typeof InheritanceType],
      this.name,
      this.description
    );
  }
}

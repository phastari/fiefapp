import { Livingcondition, LivingconditionType } from '../livingcondition';

interface ILivingconditionAlternative {
  type: string;
  baseCost: number;
  luxuryCost: number;
  focusGain: number;
  wellbeingGain: number;
  description: string;
}

export class LivingconditionAlternative implements ILivingconditionAlternative {
  constructor(
    public type: string,
    public baseCost: number,
    public luxuryCost: number,
    public focusGain: number,
    public wellbeingGain: number,
    public description: string
  ) {}

  public create(): Livingcondition {
    return new Livingcondition(
      LivingconditionType[this.type as keyof typeof LivingconditionType],
      this.baseCost,
      this.luxuryCost,
      this.focusGain,
      this.wellbeingGain,
      this.description
    );
  }
}

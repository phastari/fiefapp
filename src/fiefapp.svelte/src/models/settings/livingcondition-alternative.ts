import { Livingcondition, LivingconditionType } from '../livingcondition';

interface ILivingconditionAlternative {
  type: string;
  baseCost: number;
  luxuryCost: number;
  focusGain: number;
  wellbeing: number;
  description: string;
}

export class LivingconditionAlternative implements ILivingconditionAlternative {
  constructor(
    public type: string,
    public baseCost: number,
    public luxuryCost: number,
    public focusGain: number,
    public wellbeing: number,
    public description: string
  ) {}

  public create(): Livingcondition {
    return new Livingcondition(
      LivingconditionType[this.type as keyof typeof LivingconditionType],
      this.baseCost,
      this.luxuryCost,
      this.focusGain,
      this.wellbeing,
      this.description
    );
  }
}

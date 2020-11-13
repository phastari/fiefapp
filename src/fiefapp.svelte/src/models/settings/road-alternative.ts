import { Road, RoadType } from '../road';

interface IRoadAlternative {
  type: string;
  description: string;
  upgradeBaseCost: number;
  upgradeStoneCost: number;
  modificationFactor: number;
}

export class RoadAlternative implements IRoadAlternative {
  constructor(
    public type: string,
    public description: string,
    public upgradeBaseCost: number,
    public upgradeStoneCost: number,
    public modificationFactor: number
  ) {}

  public create(): Road {
    return new Road(
      this.description,
      RoadType[this.type as keyof typeof RoadType],
      this.upgradeBaseCost,
      this.upgradeStoneCost,
      this.modificationFactor
    );
  }
}

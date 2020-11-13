import { Building } from '../building';

interface IBuildingAlternative {
  type: string;
  upkeep: number;
  woodwork: number;
  stonework: number;
  smithswork: number;
  wood: number;
  stone: number;
  iron: number;
}

export class BuildingAlternative implements IBuildingAlternative {
  constructor(
    public type: string,
    public upkeep: number,
    public woodwork: number,
    public stonework: number,
    public smithswork: number,
    public wood: number,
    public stone: number,
    public iron: number
  ) {}

  public create(): Building {
    return new Building(
      this.type,
      this.upkeep,
      this.woodwork,
      this.stonework,
      this.smithswork,
      this.wood,
      this.stone,
      this.iron
    );
  }
}

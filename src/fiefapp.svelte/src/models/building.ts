import { v4 as uuidv4 } from 'uuid';

interface IBuilding {
  buildingId: string;
  builderId?: string;
  type: string;
  amount: number;
  woodworkThisYear: number;
  stoneworkThisYear: number;
  smithsworkThisYear: number;
  woodThisYear: number;
  stoneThisYear: number;
  ironThisYear: number;
  upkeep: number;
  woodwork: number;
  stonework: number;
  smithswork: number;
  wood: number;
  stone: number;
  iron: number;
}

export class Building implements IBuilding {
  readonly buildingId: string;
  builderId?: string;
  amount: number;
  woodworkThisYear: number;
  stoneworkThisYear: number;
  smithsworkThisYear: number;
  woodThisYear: number;
  stoneThisYear: number;
  ironThisYear: number;

  constructor(
    public type: string,
    public upkeep: number,
    public woodwork: number,
    public stonework: number,
    public smithswork: number,
    public wood: number,
    public stone: number,
    public iron: number
  ) {
    this.buildingId = uuidv4();
    this.builderId = undefined;
    this.amount = 0;
    this.woodworkThisYear = 0;
    this.stoneworkThisYear = 0;
    this.smithsworkThisYear = 0;
    this.woodThisYear = 0;
    this.stoneThisYear = 0;
    this.ironThisYear = 0;
  }
}

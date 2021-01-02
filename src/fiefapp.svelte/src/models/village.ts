interface IVillage {
  id: string;
  name: string;
  serfdoms: number;
  farmers: number;
  boatbuilders: number;
  tanneres: number;
  millers: number;
  furriers: number;
  tailors: number;
  blacksmiths: number;
  carpenters: number;
  innkeepers: number;
}

export class Village implements IVillage {
  id: string;
  name: string;
  serfdoms: number;
  farmers: number;
  boatbuilders: number;
  tanneres: number;
  millers: number;
  furriers: number;
  tailors: number;
  blacksmiths: number;
  carpenters: number;
  innkeepers: number;

  constructor() {
    this.id = '';
    this.name = 'Ny by';
    this.serfdoms = 0;
    this.farmers = 0;
    this.boatbuilders = 0;
    this.tanneres = 0;
    this.millers = 0;
    this.furriers = 0;
    this.tailors = 0;
    this.blacksmiths = 0;
    this.carpenters = 0;
    this.innkeepers = 0;
  }
}

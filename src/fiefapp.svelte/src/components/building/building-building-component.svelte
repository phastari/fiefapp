<script lang="ts">
  export let type: string;
  export let woodworkThisYear: number;
  export let stoneworkThisYear: number;
  export let smithsworkThisYear: number;
  export let woodThisYear: number;
  export let stoneThisYear: number;
  export let ironThisYear: number;
  export let woodwork: number;
  export let stonework: number;
  export let smithswork: number;
  export let wood: number;
  export let stone: number;
  export let iron: number;

  let resourcesNeededThisYear: IResources;

  interface IResources {
    stone: number;
    iron: number;
    wood: number;
  }

  let yearsLeft: string;
  $: yearsLeft = calculateYearsLeft();

  const calculateYearsLeft = (): string => {
    let yearsLeft = calculateWorkloadYears();
    resourcesNeededThisYear = calculateResourcesNeeded(
      yearsLeft === 0 ? 1 : yearsLeft
    );

    if (yearsLeft !== 0) {
      if (
        stoneThisYear !== resourcesNeededThisYear.stone ||
        woodThisYear !== resourcesNeededThisYear.wood ||
        ironThisYear !== resourcesNeededThisYear.iron
      ) {
        return '-';
      }

      return `${yearsLeft}`;
    }

    return '-';
  };

  const calculateResourcesNeeded = (years: number): IResources => {
    return {
      stone: Math.ceil(stone / years),
      iron: Math.ceil(iron / years),
      wood: Math.ceil(wood / years),
    };
  };

  const calculateWorkloadYears = (): number => {
    let estimatedYearsWoodwork = Math.ceil(woodwork / woodworkThisYear);
    let estimatedYearsSmithswork = Math.ceil(smithswork / smithsworkThisYear);
    let estimatedYearsStonework = Math.ceil(stonework / stoneworkThisYear);

    return Math.max(
      isNaN(estimatedYearsSmithswork) ? 0 : estimatedYearsSmithswork,
      isNaN(estimatedYearsWoodwork) ? 0 : estimatedYearsWoodwork,
      isNaN(estimatedYearsStonework) ? 0 : estimatedYearsStonework
    );
  };
</script>

<style>
</style>

<div class="row">
  <input readonly bind:value={type} />
  <input bind:value={stoneworkThisYear} type="number" />
  /
  <input readonly bind:value={stonework} type="number" />
  <input bind:value={smithsworkThisYear} type="number" />
  /
  <input readonly bind:value={smithswork} type="number" />
  <input bind:value={woodworkThisYear} type="number" />
  /
  <input readonly bind:value={woodwork} type="number" />

  <input bind:value={stoneThisYear} type="number" />
  /
  <input readonly bind:value={resourcesNeededThisYear.stone} type="number" />
  <input bind:value={ironThisYear} type="number" />
  /
  <input readonly bind:value={resourcesNeededThisYear.iron} type="number" />
  <input bind:value={woodThisYear} type="number" />
  /
  <input readonly bind:value={resourcesNeededThisYear.wood} type="number" />
  <input readonly bind:value={yearsLeft} />
</div>

export function selectTextOnFocus(node: HTMLInputElement) {
  console.log('!!');
  const handleFocus = (event: FocusEvent) => {
    node && typeof node.select === 'function' && node.select();
  };

  node.addEventListener('focus', handleFocus);

  return {
    destroy() {
      node.removeEventListener('focus', handleFocus);
    },
  };
}

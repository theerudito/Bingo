function downloadFilePdf(fileName, byteArray) {
    var blob = new Blob([new Uint8Array(byteArray)], { type: 'application/pdf' });
    var link = document.createElement('a');
    link.href = window.URL.createObjectURL(blob);
    link.download = fileName;

    link.click();
    window.URL.revokeObjectURL(link.href);
}
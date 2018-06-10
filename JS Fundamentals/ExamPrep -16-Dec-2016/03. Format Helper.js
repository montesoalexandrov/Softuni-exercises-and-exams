function formatText(arr) {
    let text = arr[0];

    text = text.replace(/[.,!?:;]\s*/g, (match) => match.trim() + " ");
    text = text.replace(/\s+[.,!?:;]/g, (match) => match.trim());
    text = text.replace(/\.\s*\.\s*\.\s*\!/g, "...!");
    text = text.replace(/(\.\s+)(\d+)/g, (match, gr1, gr2) => gr1.trim() + gr2);
    text = text.replace(/\"(\s*[^\"]+\s*)\"/g, (match, gr1) => `"${gr1.trim()}"`);
    console.log(text);
}

formatText(['Terribly formatted text . With chaotic spacings." Terrible quoting "! Also this date is pretty confusing : 20 . 12. 16 .']);
formatText(['Make,sure to give:proper spacing where is needed... !']);
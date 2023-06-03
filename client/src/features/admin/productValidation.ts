import * as yup from 'yup';

export const validationSchema = yup.object({
  name: yup.string().required(),
  collecion: yup.string().required(),
  price: yup.number().required().moreThan(100),
  quantityInStock: yup.number().required().min(0),
  size: yup.string().required(),
  releaseDate: yup.date().required(),
  condition: yup.string().required(),
  style: yup.string().required(),
  description: yup.string().required(),
  file: yup
    .mixed()
    .test(
      'file',
      'You need to provide a file',
      function (value) {
        const pictureUrl = this.resolve(yup.ref('pictureUrl'));
        return !pictureUrl || value !== undefined;
      }
    )
});
